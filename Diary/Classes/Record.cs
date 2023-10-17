using Diary.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace Diary.Classes
{
    public class Record
    {
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private List<string> _text;
        public List<string> Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public string TextStr
        {
            get
            {
                return string.Join(Environment.NewLine, Text);
            }
        }

        private string _caption = "";
        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }

        private string _emotion;
        public string Emotion
        {
            get { return _emotion; }
            set { _emotion = value;
 }
        }

        public Image EmotionPic
        {
            get
            {
                switch (Emotion)
                {
                    case "0": return Resources.IconArrowsCenter;
                    case "+-": return Resources.IconArrows;
                    case "+": return Resources.IconArrowUp;
                    case "++": return Resources.IconArrowUpDouble;
                    case "-": return Resources.IconArrowDown;
                    case "--": return Resources.IconArrowDownDouble;
                    default: return new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                }
            }
        }

        private List<Entity> _entities;
        [XmlIgnore]
        public List<Entity> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }

        private List<int> _entitiesIds;
        public List<int> EntitiesIds
        {
            get
            {
                if (Entities != null && Entities.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Entity entity in Entities)
                        ids.Add(entity.Id);
                    return ids;
                }
                return _entitiesIds;
            }
            set { _entitiesIds = value; }
        }

        private List<string> _tags;
        public List<string> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        private List<Tag> _tagList;
        [XmlIgnore]
        public List<Tag> TagList
        {
            get { return _tagList; }
            set { _tagList = value; }
        }

        private List<int> _tagsIds;
        public List<int> TagsIds
        {
            get
            {
                if (TagList != null && TagList.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Tag tag in TagList)
                        ids.Add(tag.Id);
                    return ids;
                }
                return _tagsIds;
            }
            set { _tagsIds = value; }
        }

        public Record()
        {
            Date = DateTime.Now;
            Tags = new List<string>();
            TagList = new List<Tag>();
            Entities = new List<Entity>();
            Text = new List<string>();
        }

        public override string ToString()
        {
            return Caption;
        }

        public static int CompareByDate(Record a, Record b)
        {
            if (a.Date == b.Date)
                return string.Compare(a.Caption, b.Caption);
            return DateTime.Compare(b.Date, a.Date);
        }
    }

    public class RecordsCollection
    {
        private static string fileName = "Diary.xml";
        private static RecordsCollection _recordsCollection;

        private List<Entity> _entities;
        public List<Entity> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }

        private List<Tag> _tags;
        public List<Tag> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        private List<Record> _records;
        public List<Record> Records
        {
            get { return _records; }
            set { _records = value; }
        }

        private RecordsCollection()
        {
            Entities = new List<Entity>();
            Tags = new List<Tag>();
            Records = new List<Record>();
        }

        public static RecordsCollection GetInstance()
        {
            if (_recordsCollection == null)
                _recordsCollection = Load();
            return _recordsCollection;
        }

        public bool Save()
        {
            try
            {
                XmlHelper.SerializeAndSave(fileName, this);
                return Check();
            }
            catch
            {
                return false;
            }
        }

        private bool Check()
        {
            try
            {
                RecordsCollection toCheck = fileName.LoadAndDeserialize<RecordsCollection>();
                if (toCheck.Records.Count != Records.Count)
                    return false;
                if (toCheck.Tags.Count != Tags.Count)
                    return false;
                if (toCheck.Entities.Count != Entities.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static RecordsCollection Load()
        {
            RecordsCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<RecordsCollection>();
            }
            catch
            {
                return new RecordsCollection();
            }

            /*foreach (Entity entity in result.Entities)
            {
                entity.TextStrings.Clear();
                string[] textStrings = entity.Text.Split('\n');
                foreach (string str in textStrings)
                    entity.TextStrings.Add(str.Trim());
                entity.Text = "";
            }*/

            SetTagsParents(result.Tags);
            SetRecordsEntities(result.Records, result.Entities);
            SetRecordsTags(result.Records, result.Tags);

            foreach (Record record in result.Records)
            {
                foreach (string tagStr in record.Tags)
                {
                    Tag tag = result.Tags.Find(t => t.Name == tagStr);
                    if (tag == null)
                    {
                        tag = new Tag() { Name = tagStr };
                        result.Add(tag);
                    }
                    if (!record.TagList.Contains(tag))
                        record.TagList.Add(tag);
                }
                record.Tags.Clear();
            }

            result.Records.Sort(Record.CompareByDate);
            result.Entities.Sort(Entity.CompareByName);
            result.Tags.Sort(Tag.CompareByParent);

            return result;
        }

        private static void SetTagsParents(List<Tag> tags)
        {
            foreach (Tag tag in tags)
                if (tag.ParentId != -1)
                    tag.Parent = tags.Find(i => i.Id == tag.ParentId);
        }

        private static void SetRecordsTags(List<Record> records, List<Tag> tags)
        {
            foreach (Record record in records)
                foreach (int tagId in record.TagsIds)
                    foreach (Tag tag in tags)
                        if (tag.Id == tagId)
                        {
                            record.TagList.Add(tag);
                            break;
                        }
        }
        
        private static void SetRecordsEntities(List<Record> records, List<Entity> entities)
        {
            foreach (Record record in records)
                foreach (int entityId in record.EntitiesIds)
                    foreach (Entity entity in entities)
                        if (entity.Id == entityId)
                        {
                            record.Entities.Add(entity);
                            break;
                        }
        }

        public void Add(Entity entity)
        {
            int lastId = -1;
            foreach (Entity e in Entities)
                if (e.Id > lastId)
                    lastId = e.Id;

            entity.Id = lastId + 1;

            Entities.Add(entity);
            Entities.Sort(Entity.CompareByName);
        }

        public void Add(Tag tag)
        {
            int lastId = -1;
            foreach (Tag i in Tags)
                if (i.Id > lastId)
                    lastId = i.Id;

            tag.Id = lastId + 1;

            Tags.Add(tag);
            Tags.Sort(Tag.CompareByParent);
        }

        public void Add(Record record)
        {
            Records.Add(record);
            Records.Sort(Record.CompareByDate);
        }

        public static List<Tag> GetSubTags(Tag tag)
        {
            List<Tag> result = new List<Tag>();
            result.Add(tag);
            foreach (Tag subItem in RecordsCollection.GetInstance().Tags.FindAll(t => t.Parent == tag))
                result.AddRange(GetSubTags(subItem));
            return result;
        }

        public List<string> GetAllTags(Tag tag, string prefix = "")
        {
            List<string> result = new List<string>();

            if (tag != null)
                result.Add(prefix + tag.Name);

            List<Tag> subTags = tag != null ? Tags.FindAll(t => t.Parent == tag) : Tags.FindAll(t => t.Parent == null);

            foreach (Tag subTag in subTags)
                result.AddRange(GetAllTags(subTag, prefix + "  "));

            return result;
        }
    }
}
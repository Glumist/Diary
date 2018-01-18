using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Diary
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

        private string _caption = "";
        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
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

        public Record()
        {
            Date = DateTime.Now;
            Tags = new List<string>();
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

        private List<Record> _records;
        public List<Record> Records
        {
            get { return _records; }
            set { _records = value; }
        }

        private RecordsCollection()
        {
            Entities = new List<Entity>();
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

            SetRecordsEntities(result.Records, result.Entities);

            result.Records.Sort(Record.CompareByDate);
            result.Entities.Sort(Entity.CompareByName);

            return result;
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

        public void Add(Record record)
        {
            Records.Add(record);
            Records.Sort(Record.CompareByDate);
        }

        public List<string> GetAllTags()
        {
            List<string> result = new List<string>();

            foreach (Record record in Records)
                foreach (string tag in record.Tags)
                    if (!result.Contains(tag))
                        result.Add(tag);

            result.Sort();

            return result;
        }
    }
}

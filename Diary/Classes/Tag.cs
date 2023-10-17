using System.Xml.Serialization;

namespace Diary.Classes
{
    public class Tag
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Tag _parent;
        [XmlIgnore]
        public Tag Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private int _parentId = -1;
        public int ParentId
        {
            get
            {
                if (Parent != null)
                    return Parent.Id;
                return _parentId;
            }
            set { _parentId = value; }
        }

        public override string ToString()
        {
            return (Parent != null ? Parent.Name + " - " : "") + Name;
        }

        public static int CompareByParent(Tag a, Tag b)
        {
            if (a.Parent == b.Parent)
                return CompareByName(a, b);
            else if (a.Parent == null)
                return 1;
            else if (b.Parent == null)
                return -1;
            return Tag.CompareByName(a.Parent, b.Parent);
        }

        public static int CompareByName(Tag a, Tag b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}
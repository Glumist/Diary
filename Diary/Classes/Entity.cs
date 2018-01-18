using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    public class Entity
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public Entity()
        {
            Text = new List<string>();
        }

        public override string ToString()
        {
            return Caption;
        }

        public static int CompareByName(Entity a, Entity b)
        {
            return string.Compare(a.Caption, b.Caption);
        }
    }
}

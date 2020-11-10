using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_Layout.Class
{
    public class BaseClass
    {
        //public List<Class> List;
        private string _class;
        public string Class
        {
            get { return _class; }
            set
            {
                _class = value;
            }
        }
    }
}

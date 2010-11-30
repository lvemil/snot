using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class TaggedValue
    {
        private Tag _Tag;
        private List<string> _Values = new List<string>();

        public List<string> Values
        {
            get { return _Values; }
            set { _Values = value; }
        }

        public Tag Tag
        {
            get { return _Tag; }
            set { _Tag = value; }
        }

        public TaggedValue(Tag tag, params string[] values)
        {
            _Tag = tag;
            _Values.AddRange(values);
        }
    }
}

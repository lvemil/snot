using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    class Tag
    {
        private string _Text;

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public Tag(string text)
        {
            _Text = text;
        }
    }
}

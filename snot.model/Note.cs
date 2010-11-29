using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class Note
    {
        private string _Title;
        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
        private DateTime _DateModified;

        public DateTime DateModified
        {
            get { return _DateModified; }
            set { _DateModified = value; }
        }
        private User _Author;

        public User Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        private List<TopicAppearance> _Topics;

        public List<TopicAppearance> Topics
        {
            get { return _Topics; }
            set { _Topics = value; }
        }

        private List<TaggedValue> _Tags;

        internal List<TaggedValue> Tags
        {
            get { return _Tags; }
            set { _Tags = value; }
        }

        
    }
}

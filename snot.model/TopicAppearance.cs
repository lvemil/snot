using System;
using System.Collections.Generic;
using System.Text;

namespace snot.model
{
    public class TopicAppearance
    {
        private Topic _Topic;

        public Topic Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
        }
        
        private List<Idea> _Ideas = new List<Idea>();

        public List<Idea> Ideas
        {
            get { return _Ideas; }
            set { _Ideas = value; }
        }

        public TopicAppearance(Topic topic)
        {
            _Topic = topic;
        }
    }
}

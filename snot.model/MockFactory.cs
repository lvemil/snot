using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class MockFactory
    {
        public static Note CreateNote()
        {
            Note n = new Note();
            n.Author = new User("elima");
            n.DateCreated = new DateTime(2010, 11, 10);
            n.Tags.Add(new TaggedValue(new Tag("lugar"), "sala altun ha"));


            Topic t1 = new Topic("ReqControlAcceso");
            TopicAppearance ta1 = new TopicAppearance(t1);
            ta1.Ideas.Add(new Idea("{0}liberar el sistema", new TaggedValue(new Tag("acuerdo"), "elima", "3-1-2011")));

            return n;
        }
    }
}

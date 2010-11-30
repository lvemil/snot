using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class MockFactory
    {
        public static Note CreateNote1()
        {
            Note n = new Note();
            n.Author = new User("elima");
            n.DateCreated = new DateTime(2010, 11, 10);
            n.Tags.Add(new TaggedValue(new Tag("lugar"), "sala altun ha"));

            Topic t1 = new Topic("ReqControlAcceso");
            TopicAppearance ta1 = new TopicAppearance(t1);
            ta1.Ideas.Add(new Idea("{0}liberar el sistema", new TaggedValue(new Tag("acuerdo"), "elima", "3-1-2011")));
            ta1.Ideas.Add(new Idea("{0}involucrar a lider del negocio", new TaggedValue(new Tag("acuerdo"), "elima", "3-10-2010")));

            return n;
        }

        public static Note CreateNote2()
        {
            Note n = new Note();
            n.Author = new User("elima");
            n.DateCreated = new DateTime(2010, 11, 15);
            n.Tags.Add(new TaggedValue(new Tag("lugar"), "sala yaxchilan"));
            n.Tags.Add(new TaggedValue(new Tag("asunto"), "One2One RH"));

            Topic t1 = new Topic("ReqControlAcceso");
            TopicAppearance ta1 = new TopicAppearance(t1);
            ta1.Ideas.Add(new Idea("{0}no se ha podido liberar el sistema", new TaggedValue(new Tag("problema"))));

            Topic t2 = new Topic("SistemaReservaciones");
            TopicAppearance ta2 = new TopicAppearance(t2);
            ta2.Ideas.Add(new Idea("Es necesarario una actualizacion del sistema"));
            ta2.Ideas.Add(new Idea("{0}el sistema esta trabajando correctamente", new TaggedValue(new Tag("exito"))));

            return n;
        }
    }
}

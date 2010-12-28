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
            Note n = new Note("note 1", new User("elima"));
            n.DateCreated = new DateTime(2010, 11, 10);
            n.Tags.Add(new ValuedTag(new Tag("lugar"), "sala altun ha"));

            Topic t1 = new Topic("ReqControlAcceso");
            TopicAppearance ta1 = new TopicAppearance(t1);
            ta1.Order = 1;
            ta1.Level = 1;
            ta1.Ideas.Add(new Idea("{0}liberar el sistema", new ValuedTag(new Tag("acuerdo"), "elima", "3-1-2011")));
            ta1.Ideas.Add(new Idea("{0}involucrar a lider del negocio", new ValuedTag(new Tag("acuerdo"), "elima", "3-10-2010")));

            n.Topics.Add(ta1);

            return n;
        }

        public static Note CreateNote2()
        {
            Note n = new Note("nota 2", new User("elima"));
            n.DateCreated = new DateTime(2010, 11, 15);
            n.Tags.Add(new ValuedTag(new Tag("lugar"), "sala yaxchilan"));
            n.Tags.Add(new ValuedTag(new Tag("asunto"), "One2One RH"));

            Topic t1 = new Topic("ReqControlAcceso");
            TopicAppearance ta1 = new TopicAppearance(t1);
            ta1.Order = 1;
            ta1.Level = 1;
            ta1.Ideas.Add(new Idea("{0}no se ha podido liberar el sistema", new ValuedTag(new Tag("problema"))));

            Topic t2 = new Topic("SistemaReservaciones");
            TopicAppearance ta2 = new TopicAppearance(t2);
            ta2.Order = 2;
            ta2.Level = 1;
            ta2.Ideas.Add(new Idea("Es necesarario una actualizacion del sistema"));
            ta2.Ideas.Add(new Idea("{0}el sistema esta trabajando correctamente", new ValuedTag(new Tag("exito"))));

            Topic t3 = new Topic("ProximasIniciativas");
            TopicAppearance ta3 = new TopicAppearance(t3);
            ta3.Order = 3;
            ta3.Level = 2;
            ta3.Ideas.Add(new Idea("Migracion a nueva version"));
            //ta2.SubTopics.Add(ta3);

            n.Topics.Add(ta1);
            n.Topics.Add(ta2);
            n.Topics.Add(ta3);

            return n;
        }

        public static List<Note> LoadNotes()
        {
            List<Note> res = new List<Note>();
            res.Add(CreateNote1());
            res.Add(CreateNote2());

            return res;
        }
    }
}

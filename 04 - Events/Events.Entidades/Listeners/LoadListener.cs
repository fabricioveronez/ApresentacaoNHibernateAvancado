using Newtonsoft.Json;
using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Entidades.Listeners
{
    public class InsertListener : IPostInsertEventListener
    {
        public void OnPostInsert(PostInsertEvent @event)
        {
            Console.WriteLine(JsonConvert.SerializeObject(@event.Entity, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        public Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(JsonConvert.SerializeObject(@event.Entity, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            })));
        }
    }
}

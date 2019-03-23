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
            Orders order = (Orders)@event.Entity;
            Console.WriteLine($@"Insert - {order.OrderID}");
        }

        public Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
        {
            Orders order = (Orders)@event.Entity;
            return Task.Run(() => Console.WriteLine($@"Insert - {order.OrderID}"));
        }
    }
}

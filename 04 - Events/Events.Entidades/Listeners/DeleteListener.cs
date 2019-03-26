using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Entidades.Listeners
{
    public class DeleteListener : IPostDeleteEventListener
    {
        public void OnPostDelete(PostDeleteEvent @event)
        {
            if (@event.Entity is Orders)
            {
                Orders order = (Orders)@event.Entity;
                Console.WriteLine($@"Delete - {order.OrderID}");
            }
        }

        public Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken)
        {
            if (@event.Entity is Orders)
            {
                Orders order = (Orders)@event.Entity;
                return Task.Run(() => Console.WriteLine($@"Delete - {order.OrderID}"));
            }
            else
            {
                return Task.Run(() => { });
            }
        }
    }
}

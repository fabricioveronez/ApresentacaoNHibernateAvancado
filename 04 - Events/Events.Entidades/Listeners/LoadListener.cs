using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Entidades.Listeners
{
    public class LoadListener : ILoadEventListener
    {
        public void OnLoad(LoadEvent @event, LoadType loadType)
        {
            
        }

        public Task OnLoadAsync(LoadEvent @event, LoadType loadType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

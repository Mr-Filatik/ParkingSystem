using Ecs.Components;
using Ecs.Components.Events;
using Leopotam.Ecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecs.Systems
{
    sealed class InitMapSystem : IEcsRunSystem
    {
        readonly EcsWorld _world = null;

        readonly UIConfig uIConfig = null;

        readonly EcsFilter<InitMapEvent> initMapEvents = null;

        public void Run()
        {
            foreach (var unused in initMapEvents)
            {
                if (false) //is booking or occupied - yes
                {

                }
                else
                {
                    _world.NewEntity().Get<ActiveWindowComponent>().ActiveWindow = uIConfig.InfoWindow;
                    uIConfig.InfoWindow.Show(true);
                    uIConfig.BookingWindow.Show(false);
                }
            }
        }
    }
}

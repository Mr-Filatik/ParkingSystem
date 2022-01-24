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
    sealed class ChangeBackgroundSystem : IEcsRunSystem
    {
        readonly UIConfig uIConfig = null;

        readonly EcsFilter<ChangeBackgroundEvent> changeBackgroundEvents = null;

        public void Run()
        {
            foreach (var idx in changeBackgroundEvents)
            {
                ref var e = ref changeBackgroundEvents.Get1(idx);
                uIConfig.UIBackground.Show(e.State);
            }
        }
    }
}

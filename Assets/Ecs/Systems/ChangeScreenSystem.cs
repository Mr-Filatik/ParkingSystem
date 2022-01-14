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
    sealed class ChangeScreenSystem : IEcsRunSystem
    {
        readonly EcsFilter<ChangeScreenEvent> changeScreenEvents = null;
        readonly EcsFilter<ActiveScreenComponent> activeScreenComponents = null;

        public void Run()
        {
            foreach (var idx in changeScreenEvents)
            {
                ref var e = ref changeScreenEvents.Get1(idx);
                foreach (var idx1 in activeScreenComponents)
                {
                    ref var c = ref activeScreenComponents.Get1(idx1);
                    c.ActiveScreen.Show(false);
                    c.ActiveScreen = e.Screen;
                    c.ActiveScreen.Show(true);
                }
            }
        }
    }
}

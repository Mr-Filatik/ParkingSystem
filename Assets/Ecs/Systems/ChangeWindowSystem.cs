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
    sealed class ChangeWindowSystem : IEcsRunSystem
    {
        readonly EcsFilter<ChangeWindowEvent> changeWindowEvents = null;
        readonly EcsFilter<ActiveWindowComponent> activeWindowComponents = null;

        public void Run()
        {
            foreach (var idx in changeWindowEvents)
            {
                ref var e = ref changeWindowEvents.Get1(idx);
                foreach (var idx1 in activeWindowComponents)
                {
                    ref var c = ref activeWindowComponents.Get1(idx1);
                    c.ActiveWindow.Show(false);
                    c.ActiveWindow = e.Window;
                    c.ActiveWindow.Show(true);
                }
            }
        }
    }
}

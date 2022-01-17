using Ecs.Components.Events;
using Leopotam.Ecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecs.Systems
{
    sealed class LogoutSystem : IEcsRunSystem
    {
        readonly EcsWorld _world = null;

        readonly UIConfig uIConfig = null;

        readonly EcsFilter<LogoutEvent> logoutEvents = null;

        public void Run()
        {
            foreach (var unused in logoutEvents)
            {
                ref var component = ref _world.NewEntity().Get<ChangeScreenEvent>();
                component.Screen = uIConfig.LoginScreen;
            }
        }
    }
}

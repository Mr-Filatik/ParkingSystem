using Ecs.Components.Events;
using Leopotam.Ecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecs.Systems
{
    sealed class LoginSystem : IEcsRunSystem
    {
        readonly EcsWorld _world = null;
        readonly UIConfig uIConfig = null;
        readonly EcsFilter<LoginEvent> loginEvents = null;

        public void Run()
        {
            foreach (var unused in loginEvents)
            {
                string login = uIConfig.inputLogin.text;
                string password = uIConfig.inputPassword.text;
                uIConfig.inputPassword.text = "";
                if (login == "admin" && password == "admin")
                {
                    ref var component = ref _world.NewEntity().Get<ChangeScreenEvent>();
                    component.Screen = uIConfig.MapScreen;
                }
                else
                {
                    //ref var component = ref _world.NewEntity().Get<ChangeScreenEvent>();
                    //component.Screen = uIConfig.MapScreen;
                }
            }
        }
    }
}

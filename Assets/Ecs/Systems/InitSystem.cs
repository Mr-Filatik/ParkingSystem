using Ecs.Components;
using Ecs.Components.Events;
using Leopotam.Ecs;

namespace Ecs.Systems {
    sealed class InitSystem : IEcsInitSystem 
    {
        readonly EcsWorld _world = null;
        readonly UIConfig uIConfig = null;

        public void Init () {
            if (false) //is authorization - yes
            {
                _world.NewEntity().Get<ChangeBackgroundEvent>().State = false;
                _world.NewEntity().Get<ActiveScreenComponent>().ActiveScreen = uIConfig.MapScreen; 
                _world.NewEntity().Get<InitMapEvent>();
                uIConfig.LoginScreen.Show(false);
                uIConfig.MapScreen.Show(true);
            }
            else
            {
                _world.NewEntity().Get<ChangeBackgroundEvent>().State = true;
                _world.NewEntity().Get<ActiveScreenComponent>().ActiveScreen = uIConfig.LoginScreen;
                uIConfig.LoginScreen.Show(true);
                uIConfig.MapScreen.Show(false);
            }
            uIConfig.LogoutScreen.Show(false);
            uIConfig.SettingsScreen.Show(false);
            uIConfig.ProblemScreen.Show(false);
        }
    }
}
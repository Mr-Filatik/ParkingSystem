using Ecs.Components;
using Leopotam.Ecs;

namespace Ecs.Systems {
    sealed class InitSystem : IEcsInitSystem 
    {
        readonly EcsWorld _world = null;

        readonly UIConfig uIConfig = null;

        public void Init () {
            _world.NewEntity().Get<ActiveScreenComponent>().ActiveScreen = uIConfig.LoginScreen;
            if (false) //is authorization - yes
            {
                uIConfig.LoginScreen.Show(false);
                uIConfig.MapScreen.Show(true);
            }
            else
            {
                uIConfig.LoginScreen.Show(true);
                uIConfig.MapScreen.Show(false);
            }
            uIConfig.LogoutScreen.Show(false);
            uIConfig.SettingsScreen.Show(false);
            uIConfig.ProblemScreen.Show(false);
        }
    }
}
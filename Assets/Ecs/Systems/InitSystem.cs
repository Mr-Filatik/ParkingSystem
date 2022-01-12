using Ecs.Components;
using Leopotam.Ecs;

namespace Ecs.Systems {
    sealed class InitSystem : IEcsInitSystem {
        // auto-injected fields.
        readonly EcsWorld _world = null;

        readonly UIConfig uIConfig = null;

        public void Init () {
            _world.NewEntity().Get<ActiveScreenComponent>().ActiveScreen = uIConfig.LoginScreen;
            uIConfig.LoginScreen.Show(true);
        }
    }
}
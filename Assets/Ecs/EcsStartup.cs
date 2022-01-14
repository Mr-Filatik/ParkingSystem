using Ecs.Components.Events;
using Ecs.Systems;
using Leopotam.Ecs;
using Leopotam.Ecs.Ui.Components;
using Leopotam.Ecs.Ui.Systems;
using UnityEngine;

namespace Ecs
{
    sealed class EcsStartup : MonoBehaviour
    {
        [SerializeField] private UIConfig uIConfig = null;
        [SerializeField] EcsUiEmitter uiEmitter = null;

        EcsWorld _world;
        EcsSystems _systems;

        void Start()
        {
            // void can be switched to IEnumerator for support coroutines.

            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(_systems);
#endif
            _systems
                 // register your systems here, for example:
                 .Add(new InitSystem())
                 .Add(new UIClickSystem())
                 .Add(new LoginSystem())
                 .Add(new ChangeScreenSystem())

                 // register one-frame components (order is important), for example:
           
                 .OneFrame<LoginEvent>()
                 .OneFrame<ProblemEvent>()
                 .OneFrame<ChangeScreenEvent>()

                // inject service instances here (order doesn't important), for example:
                // .Inject (new CameraService ())
                .Inject(uIConfig)
                .InjectUi(uiEmitter)
                .Init();
        }

        void Update()
        {
            _systems?.Run();
        }

        void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
                _world.Destroy();
                _world = null;
            }
        }
    }
}
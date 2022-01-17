using Ecs.Components.Events;
using Leopotam.Ecs;
using Leopotam.Ecs.Ui.Components;
using UnityEngine;

namespace Ecs.Systems
{
    sealed class UIClickSystem : IEcsRunSystem
    {
        readonly EcsWorld _world = null;
        readonly UIConfig uIConfig = null;
        readonly EcsFilter<EcsUiClickEvent> clickEvents = null;

        public void Run()
        {
            foreach (var idx in clickEvents)
            {
                ref var e = ref clickEvents.Get1(idx);
                switch (e.WidgetName)
                {
                    case Data.Widgets.Login:
                        switch (e.Sender.GetComponent<AppButtonInfo>().AppButtonType)
                        {
                            case AppButtonType.Login:
                                _world.NewEntity().Get<LoginEvent>();
                                break;
                            case AppButtonType.Problem:
                                ref var componentProblem = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                componentProblem.Screen = uIConfig.ProblemScreen;
                                break;
                            case AppButtonType.ProblemClose:
                                ref var componentProblemClose = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                componentProblemClose.Screen = uIConfig.LoginScreen;
                                break;
                            case AppButtonType.Logout:
                                ref var componentLogout = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                componentLogout.Screen = uIConfig.LogoutScreen;
                                break;
                            case AppButtonType.LogoutConfirm:
                                _world.NewEntity().Get<LogoutEvent>();
                                break;
                            case AppButtonType.Map:
                                ref var componentMap = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                componentMap.Screen = uIConfig.MapScreen;
                                break;
                            case AppButtonType.Settings:
                                ref var componentSettings = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                componentSettings.Screen = uIConfig.SettingsScreen;
                                break;
                            case AppButtonType.Eye:
                                //ref var componentSettings = ref _world.NewEntity().Get<ChangeScreenEvent>();
                                //componentSettings.Screen = uIConfig.SettingsScreen;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Data.Widgets.Map:
                        switch (e.Sender.GetComponent<AppButtonInfo>().AppButtonType)
                        {
                            case AppButtonType.Problem:

                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
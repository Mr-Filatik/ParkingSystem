using Leopotam.Ecs;
using Leopotam.Ecs.Ui.Components;

namespace Ecs.Systems
{
    sealed class UIClickSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        readonly EcsFilter<EcsUiClickEvent> clickEvents = null;

        public void Run()
        {
            foreach (var idx in clickEvents)
            {
                ref var e = ref clickEvents.Get1(idx);

                switch (e.WidgetName)
                {
                    case Data.Widgets.Login:
                        switch (e.Sender.GetComponent<LoginButtonInfo>().LoginButtonType)
                        {
                            case LoginButtonType.Login:

                                break;
                            case LoginButtonType.Problem:

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
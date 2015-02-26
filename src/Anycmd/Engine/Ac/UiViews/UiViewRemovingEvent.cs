﻿
namespace Anycmd.Engine.Ac.UiViews
{
    using Events;

    public class UiViewRemovingEvent: DomainEvent
    {
        public UiViewRemovingEvent(IAcSession acSession, UiViewBase source)
            : base(acSession, source)
        {
        }
    }
}

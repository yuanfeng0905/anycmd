﻿
namespace Anycmd.Engine.Ac.Groups
{
    using Events;

    public class GroupRemovingEvent: DomainEvent
    {
        public GroupRemovingEvent(IAcSession acSession, GroupBase source)
            : base(acSession, source)
        {
        }
    }
}
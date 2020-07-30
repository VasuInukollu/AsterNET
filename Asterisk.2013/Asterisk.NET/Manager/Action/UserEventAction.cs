using System;
using AsterNET.Manager.Event;

namespace AsterNET.Manager.Action
{
    public class UserEventAction : ManagerAction
    {
        public UserEventAction()
        {
        }

        public UserEventAction(string eventName, string header1)
        {
            this.UserEvent = eventName;
            this.Header1 = header1;
        }

        public override string Action
        {
            get { return "UserEvent"; }
        }

        public string UserEvent { get; set; }
        public string Header1 { get; set; }

    }
}

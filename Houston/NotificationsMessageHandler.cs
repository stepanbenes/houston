using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocketManager;
using WebSocketManager.Common;

namespace Houston
{
    public class NotificationsMessageHandler : WebSocketHandler
    {
        public NotificationsMessageHandler(WebSocketConnectionManager webSocketConnectionManager)
            : base(webSocketConnectionManager, new StringMethodInvocationStrategy())
        {
            ((StringMethodInvocationStrategy)MethodInvocationStrategy).On("test", args => {
				Console.WriteLine(args);
            });
        }
    }
}

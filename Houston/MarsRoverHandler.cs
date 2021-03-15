using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using WebSocketManager;
using WebSocketManager.Common;

namespace Houston
{
	public class MarsRoverHandler : WebSocketHandler
	{
		public MarsRoverHandler(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager, new ControllerMethodInvocationStrategy())
		{
			((ControllerMethodInvocationStrategy)MethodInvocationStrategy).Controller = this;
		}

		public IReadOnlyList<string> GetConnectedRovers() => WebSocketConnectionManager.GetAll().Keys.ToList();
	}
}

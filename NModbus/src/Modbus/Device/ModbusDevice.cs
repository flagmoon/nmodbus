using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using log4net;
using Modbus.IO;

namespace Modbus.Device
{
	public abstract class ModbusDevice
	{
		private IModbusTransport _transport;
		protected static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		internal IModbusTransport Transport
		{
			get { return _transport; }
			set { _transport = value; }
		}

		internal ModbusDevice(IModbusTransport transport)
		{
			_transport = transport;
		}
	}
}

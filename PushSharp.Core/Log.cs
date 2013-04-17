using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace PushSharp.Core
{
	public class Log
	{
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

		public static LogLevel Level = LogLevel.Info;

		public static void Info(string format, params object[] objs)
		{
			if (((int)Level) >= ((int)LogLevel.Info))
				_logger.Info(format, objs);
		}

		public static void Warning(string format, params object[] objs)
		{
			if (((int)Level) >= ((int)LogLevel.Warning))
				_logger.Warn(format, objs);
		}

		public static void Error(string format, params object[] objs)
		{
			if (((int)Level) >= ((int)LogLevel.Error))
				_logger.Error(format, objs);
		}

	}

	public enum LogLevel
	{
		None = 0,
		Warning = 1,
		Error = 2,
		Info = 3
	}
}

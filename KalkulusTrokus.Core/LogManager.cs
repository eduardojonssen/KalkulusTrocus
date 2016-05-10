using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Framework;
using System.Runtime.CompilerServices;
using KalkulusTrokus.Core.Response;
using KalkulusTrokus.Core.Request;

namespace KalkulusTrokus.Core
{
	static internal class LogManager
	{
		static String directoryPath = @"C:\LOGS\";
		static String path = directoryPath + "KalkulusTrokus.log";

		static LogManager()
		{
			try
			{
				if (Directory.Exists(directoryPath) == false)
					Directory.CreateDirectory(directoryPath);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private static void LogInternal(String stuffToLog, string type, string sourceMemberName, string sourceFileName, Nullable<int> sourceFileLineNumber)
		{
			try
			{
				File.AppendAllText(path, "[" + DateTime.Now + "] | " + type + " | " + sourceMemberName + " on " + sourceFileName + " " + sourceFileLineNumber + " | " + stuffToLog + Environment.NewLine);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public static void Log( String stuffToLog, string type, [CallerMemberName] string sourceMemberName="", [CallerFilePath] string sourceFileName="", [CallerLineNumber] Nullable<int> sourceFileLineNumber=null)
		{
			LogInternal(stuffToLog, type, sourceMemberName, sourceFileName, sourceFileLineNumber);
		}

		public static void Log(object data, [CallerMemberName] string sourceMemberName="", [CallerFilePath] string sourceFileName="", [CallerLineNumber] Nullable<int> sourceFileLineNumber=null)
		{
			String type = "unknown";

			if (data is Exception)
			{
				type = "Exception";
			}
			else if (data is AbstractResponse)
			{
				type = "Response";
			}
			else if (data is AbstractRequest)
			{
				type = "Request";
			}

			LogInternal(Serializer.NewtonsoftSerialize(data), type, sourceMemberName, sourceFileName, sourceFileLineNumber);
		}
	}
}


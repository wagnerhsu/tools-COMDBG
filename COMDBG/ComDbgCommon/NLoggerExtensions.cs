using System.Text;
using NLog;

namespace ComDbgCommon
{
    public static class NLoggerExtensions
    {
        public static void LogHexData(this ILogger logger, byte[] data)
        {
            if (logger.IsEnabled(LogLevel.Trace))
            {
                logger.Trace($"[HEX]{ConvertUtility.ByteArrayToHex(data)}");
            }
        }

        public static void LogHexData(this ILogger logger, string hexString)
        {
            if (logger.IsEnabled(LogLevel.Trace))
            {
                logger.Trace($"[HEX]{hexString}");
            }
        }

        public static void LogTextData(this ILogger logger, byte[] data, Encoding encoding)
        {
            if (logger.IsEnabled(LogLevel.Debug))
            {
                logger.Debug($"[TEXT]{encoding.GetString(data)}");
            }
        }

        public static void LogTextData(this ILogger logger, string data)
        {
            if (logger.IsEnabled(LogLevel.Debug))
            {
                logger.Debug($"[TEXT]{data}");
            }
        }
    }
}

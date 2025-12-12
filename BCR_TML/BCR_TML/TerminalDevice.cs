using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMCNS.BCR_TML
{
    public class TerminalDevice
    {
        public static TerminalDevice Terminal;

        IniFileManager _config;
        MessageHandler _messageHandler;

        public TerminalDevice(string configFileName)
        {
            _config = new IniFileManager(configFileName);

            _messageHandler = new MessageHandler();
        }

        public string SendMessage(string message)
        {
            return _messageHandler.SendMessage(message);
        }
    }
}
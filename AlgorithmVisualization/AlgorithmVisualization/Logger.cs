using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualization
{
    class Logger
    {
        private static Logger instance;
        private static RichTextBox logContainer;
        private Logger() { }

        public static Logger Instance
        {
            get{
                if (instance == null) instance = new Logger();
                return instance;
            }
        }

        public static void SetLogContainer(RichTextBox container)
        {
            logContainer = container;
        }

        public static void Log(string text)
        {
            if(logContainer != null)
            {
                logContainer.AppendText(text + "\n");
            }
        }

        public static void Clear()
        {
            if (logContainer != null) logContainer.Clear();
        }
    }
}

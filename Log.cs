using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace es.ivancruz.Utils {
    public interface ILog {
        void Info(string cad);
        void Error(string cad);
        void Debug(string cad);
    }
    public class LogTextBox : ILog {
        private TextBox tb;
        public LogTextBox(TextBox tb) {
            this.tb = tb;
        }
        public void Info(string cad) {
            this.WriteLn(cad);
        }
        private void WriteLn(string cad) {
            if (this.tb == null) {
                throw new Exception("LogTextBox no inicializado");
            }
            this.tb.AppendText(cad + Environment.NewLine);
            Application.DoEvents();
        }

        public void Error(string cad) {
            this.WriteLn("ERROR: " + cad);
        }
        public void Debug(string cad) {
            this.WriteLn("DEBUG: " + cad);
        }
    }
    public class LogDebug : ILog {
        public List<string> lMensajes = new List<string>();
        public string Get(int index) {
            return this.lMensajes[index];
        }
        public int OcurrencesOf(string cad) {
            int result = 0;
            foreach (string item in this.lMensajes) {
                if (item.Contains(cad)) {
                    result++;
                }
            }
            return result;
        }
        private void WriteMessage(string cad) {
            lMensajes.Add(cad);
        }
        public void Error(string cad) {
            this.WriteMessage(cad);
        }
        public void Info(string cad) {
            this.WriteMessage(cad);
        }
        public void Debug(string cad) {
            this.WriteMessage(cad);
        }
        public string LastMessage {
            get {
                if (lMensajes.Count == 0) {
                    return "";
                }
                return lMensajes[lMensajes.Count - 1];
            }
        }
    }
    public class LogWindows : ILog {
        string Origin;
        public bool ShowDebug = true;
        public LogWindows(string origin) {
            this.Origin = origin;
        }
        private void WriteMessage(EventLogEntryType elet, string cad) {
            EventLog.WriteEntry(this.Origin, cad, elet);
        }
        public void Error(string cad) {
            WriteMessage(EventLogEntryType.Error, cad);
        }
        public void Info(string cad) {
            WriteMessage(EventLogEntryType.Information, cad);
        }
        public void Debug(string cad) {
            if (this.ShowDebug) {
                WriteMessage(EventLogEntryType.Information, cad);
            }
        }
    }
    public class LogMultiple : ILog {
        List<ILog> lLog = new List<ILog>();
        public void Add(ILog log) {
            this.lLog.Add(log);
        }
        public ILog Get(int index) {
            return this.lLog[index];
        }
        public void Error(string cad) {
            foreach (ILog item in this.lLog) {
                item.Error(cad);
            }
        }
        public void Info(string cad) {
            foreach (ILog item in this.lLog) {
                item.Info(cad);
            }
        }
        public void Debug(string cad) {
            foreach (ILog item in this.lLog) {
                item.Debug(cad);
            }
        }
    }
}

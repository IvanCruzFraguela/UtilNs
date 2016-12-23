using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace IvanCruz.Utilns {
    public enum ELogLevel {  Fatal = 10, Error = 20, Warn = 30, Info = 40, Debug = 50, Trace = 60 , All = 200}

    public interface ILog {
        void Error(string cad, int IdEvento);
        void Info(string cad, int IdEvento = 0);
        void Debug(string cad, int IdEvento = 0);
        //Indica el nivel de error hasta el cual se muestran mensajes de log. Por ejemplo LogLevel = ELogLevel.Error mostraría mensajes Fatal y Error
        ELogLevel LogLevel { get; set; }
    }
    public class CLogTextBox : ILog {
        //Ojo al escribir procesa eventos por lo que actualiza el repintado del texbox pero también procesaría eventos de otro tipo de la aplicación.
        public ELogLevel LogLevel { get; set; } = ELogLevel.Trace;
        private TextBox tb;
        public CLogTextBox(ELogLevel logLevel, TextBox tb) {
            this.LogLevel = logLevel;
            this.tb = tb;
        }
        private void WriteLn(ELogLevel logLevel, string cad, int IdEvento) {
            if (this.tb == null) {
                throw new Exception("LogTextBox no inicializado");
            }
            if (this.LogLevel >= logLevel) {
                this.tb.AppendText(cad + Environment.NewLine);
                this.tb.Update();
            }
            //Application.DoEvents();
        }

        public void Info(string cad, int IdEvento = 0) {
            this.WriteLn(ELogLevel.Info, "INFO: " + cad, IdEvento);
        }
        public void Error(string cad, int IdEvento = 0) {
            this.WriteLn(ELogLevel.Error, "ERROR: " + cad, IdEvento);
        }
        public void Debug(string cad, int IdEvento = 0) {
            this.WriteLn(ELogLevel.Debug, "DEBUG: " + cad, IdEvento);
        }
    }
    public class CLogDebug : ILog {
        public ELogLevel LogLevel { get; set; } = ELogLevel.Trace;
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
        private void WriteMessage(ELogLevel logLevel, string cad, int IdEvento) {
            if (this.LogLevel >= logLevel) {
                lMensajes.Add("[" + IdEvento.ToString() + "]" + cad);
            }
        }
        public void Error(string cad, int IdEvento = 0) {
            this.WriteMessage(ELogLevel.Error, cad, IdEvento);
        }
        public void Info(string cad, int IdEvento = 0) {
            this.WriteMessage(ELogLevel.Info, cad, IdEvento);
        }
        public void Debug(string cad, int IdEvento = 0) {
            this.WriteMessage(ELogLevel.Debug, cad, IdEvento);
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
    public class CLogWindows : ILog {
        public ELogLevel LogLevel { get; set; } = ELogLevel.Trace;
        string Origin;
        public bool ShowDebug = true;
        public CLogWindows(ELogLevel logLevel,string origin) {
            this.LogLevel = logLevel;
            this.Origin = origin;
        }
        private void WriteMessage(ELogLevel logLevel, EventLogEntryType elet, string cad, int IdEvento) {
            if (this.LogLevel >= logLevel) {
                EventLog.WriteEntry(this.Origin, cad, elet, IdEvento);
            }
        }
        public void Error(string cad, int IdEvento = 0) {
            WriteMessage(ELogLevel.Error, EventLogEntryType.Error, cad, IdEvento);
        }
        public void Info(string cad, int IdEvento = 0) {
            WriteMessage(ELogLevel.Info, EventLogEntryType.Information, cad, IdEvento);
        }
        public void Debug(string cad, int IdEvento = 0) {
            if (this.ShowDebug) {
                WriteMessage(ELogLevel.Debug, EventLogEntryType.Information, cad, IdEvento);
            }
        }
    }
    public class CLogMultiple : ILog {
        public ELogLevel LogLevel {
            get {
                throw new ArgumentException("No se puede leer el LogLevel en un LogMultiple. Habría que hacerlo en cada log por separado.");
            }
            set {
                throw new ArgumentException("No se puede fijar el LogLevel en un LogMultiple. Habría que hacerlo en cada log por separado.");
            }
        }
        List<ILog> lLog = new List<ILog>();
        public void Add(ILog log) {
            this.lLog.Add(log);
        }
        public ILog Get(int index) {
            return this.lLog[index];
        }
        public void Error(string cad, int IdEvento = 0) {
            foreach (ILog item in this.lLog) {
                item.Error(cad, IdEvento);
            }
        }
        public void Info(string cad, int IdEvento = 0) {
            foreach (ILog item in this.lLog) {
                item.Info(cad, IdEvento);
            }
        }
        public void Debug(string cad, int IdEvento = 0) {
            foreach (ILog item in this.lLog) {
                item.Debug(cad, IdEvento);
            }
        }
    }
}

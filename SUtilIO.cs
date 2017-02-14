using System.Collections.Generic;
using System.IO;

namespace IvanCruz.Util {
    public static class SUtilIO {
        public static void CreateDirectory(string target, ILog log = null) {
            Directory.CreateDirectory(target);
            if (log != null) {
                log.Info("Creado Directorio: " + target);
            }
        }
        public static void DeteleDirectory(string Target, ILog log) {
            Directory.Delete(Target, true);
            if (log != null) {
                log.Info("Eliminado Directorio: " + Target);
            }
        }
        private static List<string> ReadFileNames(string source, ILog log = null) {
            if (!Directory.Exists(source)) {
                if (log != null) {
                    log.Error("Directorio no existe: " + source);
                }
                throw new DirectoryNotFoundException("Directorio no existe: " + source);
            } else {
                List<string> result = new List<string>();
                foreach (string item in Directory.EnumerateFiles(source)) {
                    result.Add(Path.GetFileName(item));
                }
                return result;
            }
        }
        public static void CopyDirectory(string source, string target, bool forceCreateTarget = true, bool recursive = true, ILog log = null) {
            log.Info("Directorio que se copiará de: " + source + " a " + target);
            if (recursive) {
                foreach (string dir in Directory.EnumerateDirectories(source)) {
                    log.Info(dir);
                    string onlyDir = dir.Substring(source.Length + 1);
                    SUtilIO.CopyDirectory(dir, Path.Combine(target, onlyDir), forceCreateTarget, recursive, log);
                }
            }
            List<string> lFileNames = SUtilIO.ReadFileNames(source);
            SUtilIO.CopyFiles(source, lFileNames, target, forceCreateTarget, log);
        }

        private static void CopyFiles(string source, List<string> lFileNames, string target, bool forceCreateTarget, ILog log) {
            if (forceCreateTarget) {
                SUtilIO.CreateDirectory(target, log);
            }
            foreach (var FicheroOrigen in lFileNames) {
                string rutaOrigen = Path.Combine(source, FicheroOrigen);
                string rutaDestino = Path.Combine(target, FicheroOrigen);
                try {
                    SUtilIO.CopyFile(rutaOrigen, rutaDestino, log);
                } catch (IOException ioex) {
                    if (log != null) {
                        log.Error(ioex.Message);
                    }
                    throw;
                }
            }
        }

        public static void CopyFile(string rutaOrigen, string rutaDestino, ILog log) {
            if (log != null) {
                log.Info($"Fichero que se copiará: {rutaOrigen} -> {rutaDestino}");
            }
            File.Copy(rutaOrigen, rutaDestino, true);
        }
        public static void DeleteFile(string target,ILog log) {
            if (log != null) {
                log.Info($"Se elimina fichero: {target}");
            }
            File.Delete(target);
        }
    }
}

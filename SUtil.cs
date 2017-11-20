/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 15/01/2014
 * Hora: 8:53
 * git5
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Text;
using System.Security.Cryptography;

namespace IvanCruz.Util {
	/// <summary>
	/// Description of Util.
	/// </summary>
	public static class SUtil{
       
		public static bool BoolFromFileString(string str)
		{
			return str.Equals("1");
		}
		public static string BoolToFileString(bool value){
			return value ? "1" : "0";
		}

        public static DateTime DateFromFileString(string str)
		{
			DateTime result = new DateTime(
				Convert.ToInt32(str.Substring(0,4))
				,Convert.ToInt32(str.Substring(4,2))
				,Convert.ToInt32(str.Substring(6,2))
				,Convert.ToInt32(str.Substring(8,2))
				,Convert.ToInt32(str.Substring(10,2))
				,Convert.ToInt32(str.Substring(12,2))
			);
			return result;
		}
		public static string DateToFileString(DateTime dt){
			return dt.ToString("yyyyMMddHHmmss");
		}

		public static string EmptyIfNull(string value) {
			return (value == null) ? "" : value;
		}

		static public string Encrypt(string password, string salt)
		{
			byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
			byte[] saltBytes = Encoding.Unicode.GetBytes(salt);

			byte[] cipherBytes = ProtectedData.Protect(passwordBytes, saltBytes, DataProtectionScope.CurrentUser);

			return Convert.ToBase64String(cipherBytes);
		}
		static public string Decrypt(string cipher, string salt)
		{
			byte[] cipherBytes = Convert.FromBase64String(cipher);
			byte[] saltBytes = Encoding.Unicode.GetBytes(salt);

			byte[] passwordBytes = ProtectedData.Unprotect(cipherBytes, saltBytes, DataProtectionScope.CurrentUser);

			return Encoding.Unicode.GetString(passwordBytes);
		}
        public static string DoubleQuote(string cad) {
            return "\"" + cad + "\"";
        }
        public static string Quote(string cad) {
            return "'" + cad + "'";
        }
        public static string UpperFirst(string Text) {
            if (string.IsNullOrWhiteSpace(Text)) {
                return Text;
            }
            if (Text.Length == 1) {
                return Text.ToUpper();
            }
            return Text.Substring(0, 1).ToUpper() + Text.Substring(1);
        }
        public static string LowerFirst(string Text) {
            if (string.IsNullOrWhiteSpace(Text)) {
                return Text;
            }
            if (Text.Length == 1) {
                return Text.ToLower();
            }
            return Text.Substring(0, 1).ToLower() + Text.Substring(1);
        }
        public static void CreaAccesoDirecto(string RutaFichero,string RutaADondeApuntaElLink,string DirectorioDeTrabajo) {
            Type ShellType = Type.GetTypeFromProgID("WScript.Shell");
            dynamic Shell = Activator.CreateInstance(ShellType);
            dynamic shortcut = Shell.CreateShortcut(RutaFichero);
            shortcut.TargetPath = RutaADondeApuntaElLink;
            shortcut.WorkingDirectory = DirectorioDeTrabajo;
            shortcut.Save();
        }
        public static string ToStringDateTimeSeconds(DateTime dt) {
            return dt.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public static object ToStringDateTime(DateTime dt) {
            return dt.ToString("dd/MM/yyyy HH:mm");
        }
    }
}

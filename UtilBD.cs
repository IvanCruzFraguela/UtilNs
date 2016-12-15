/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 03/05/2012
 * Hora: 12:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace IvanCruz.Utilns {
	/// <summary>
	/// Description of UtilBD.
	/// </summary>
	public static class UtilBD
	{
        public static string Param(string cad,bool forJava = false) {
            if (forJava) {
                return ":par_" + cad;
            }
            return "@par_" + cad;
        }
        public static string ParamName(string cad) {
            return "par_" + cad;
        }
        public static void AddParameter(IDbCommand com, string nomb, Object Value){
			var par = com.CreateParameter();
			par.ParameterName = nomb;
			if (Value == null){
				par.Value = DBNull.Value;
			}else{
				if(Value is string){
					if (string.IsNullOrWhiteSpace((string)Value)){
						par.Value = DBNull.Value;
					}else{
						par.Value = Value;
					}
				}else{
					par.Value = Value;
				}
			}
			com.Parameters.Add(par);
		}
		public static string QuoteStr(string cad){
			return (new StringBuilder(@"""").Append(cad).Append(@"""")).ToString();
		}
		public static int getIdentity(IDbCommand com){
			com.CommandText = "SELECT @@IDENTITY";
            object aux = com.ExecuteScalar();
            return Convert.ToInt32(aux);
		}
        public static int getIdentity(IDbConnection con) {
            using (var com = con.CreateCommand()) {
                return getIdentity(com);
            }
        }
		public static void AddCondicion(ref bool primero, StringBuilder sb,string cad){
			if(primero){
				sb.Append(" where ");
				primero = false;
			}else{
				sb.Append(" and ");
			}
			sb.Append(cad);
		}
		
	}
}

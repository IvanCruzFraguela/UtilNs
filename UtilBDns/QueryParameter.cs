/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 03/05/2012
 * Hora: 14:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IvanCruz.Util.UtilBDns
{
	/// <summary>
	/// Description of QueryParameter.
	/// </summary>
	public class QueryParameter{
		public string Nomb;
		public object Value;
		public QueryParameter(string Nomb, object Value){
			this.Nomb = Nomb;
			this.Value = Value;
		}
	}
}


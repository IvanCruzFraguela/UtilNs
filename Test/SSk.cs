using System.Threading;
using System.Windows.Forms;
/// <summary>
/// Librería que uso de Utilidades. Parte de Test
/// </summary>
namespace IvanCruz.Util.Test {
	/// <summary>
	/// Static Send Keys. Es un envoltorio para facilitar el uso de la función "SendKeys.SendWait(string keys)" y algunas utilidades más como introducir un tiempo de espera entre pulsación y 
	/// pulsación. Generar apropósito tiempo de espera (Tread.Sleep(miliseconds)) y facilita el envío de algutas teclas especiales.
	/// </summary>
	public static class SSk {
		/// <summary>
		/// Restraso estándar entre teclas
		/// </summary>
		private static int _StandarDelay = 500;
		/// <summary>
		/// Precálculo de la mitad del retraso estándar dado que se usa mucho (en cada envío de teclas)
		/// </summary>
		private static int HalfDelay = _StandarDelay / 2;
		public static int StandarDelay {
			get {
				return _StandarDelay;
			}
			set {
				StandarDelay = value;
				HalfDelay = StandarDelay / 2;
			}
		}
		/// <summary>
		/// Para la ejecución la cantidad de tiempo especificada. No pinta mucho en esta clase (nos estamos cargando el Single Responsibility) pero es cómodo llamar siempre a la misma.
		/// </summary>
		/// <param name="miliseconds">milisegundos a parar la ejecución</param>
		public static void Stop(int miliseconds) {
			Thread.Sleep(miliseconds);
		}
		/// <summary>
		/// Para la ejecución del programa la mitad del tiempo estandar. Actualmente se usa mucho dado que con cada envío se para antes y después del mismo.
		/// </summary>
		private static void StopHalfDelay() {
			Stop(HalfDelay);
		}
		/// <summary>
		/// Para la ejecución el tiempo estándar
		/// </summary>
		public static void Stop() {
			Stop(StandarDelay);
		}
		/// <summary>
		/// Envía el código con un mitad del retardo standar antes y la otra mitad después
		/// </summary>
		/// <param name="cad">Cadena codificada para enviar</param>
		public static void Code(string cad) {
			SSk.StopHalfDelay();
			SendKeys.SendWait(cad);
			SSk.StopHalfDelay();
		}
		/// <summary>
		/// Envía el texto igual que lo haría code. En principio solo deberíamos poner texto aquí.
		/// </summary>
		/// <param name="cad">Texto a enviar</param>
		public static void Text(string cad) {
			SSk.StopHalfDelay();
			SendKeys.SendWait(cad);
			SSk.StopHalfDelay();
		}
		public static void Tab() {
			Code("{TAB}");
		}
		public static void Tab(int count) {
				Code("{TAB "+count+"}");
		}
		public static void Enter() {
			Code("{ENTER}");
		}
		public static void Up() {
			Code("{UP}");
		}
		public static void Down() {
			Code("{DOWN}");
		}
		public static void Left() {
			Code("{LEFT}");
		}
		public static void Right() {
			Code("{RIGHT}");
		}
	}
}

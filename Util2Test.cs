/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 11/04/2012
 * Hora: 13:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Threading;
using System.Windows.Forms;

namespace IvanCruz.Util {
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public static class Util2Test
	{
		public static void EnviarTeclas(int TiempoEspera, string teclas) {
			Thread t = new Thread(new ParameterizedThreadStart(AEjecutarPorEnvioTeclas));
			EnvioTeclas et = new EnvioTeclas(TiempoEspera,teclas);
			t.Start(et);
		}
		private static void AEjecutarPorEnvioTeclas(Object EnvTecl) {
			EnvioTeclas aux = EnvTecl as EnvioTeclas;
			Thread.Sleep(aux.espera);
			 SendKeys.SendWait(aux.teclas);
		}
		private class EnvioTeclas {
			public int espera;
			public string teclas;
			public EnvioTeclas(int espera, string teclas) {
				this.espera = espera;
				this.teclas = teclas;
			}
		}
		public static bool NextControl(ContainerControl f) {
      return f.SelectNextControl(f.ActiveControl, true, true, true, true);
    }

    public static TextBox SetTextBoxAndNext(ContainerControl f, string cad) {
      TextBox tb = f.ActiveControl as TextBox;
      tb.Text = cad;
      NextControl(f);
      return tb;
    }

    // Hay que poner los 3 tipos. Si no se hace así no se fija el valor de SelectedValue (por no coincidir el tipo de dato) y 
    // no da error, simplemente lo deja a null
    public static ComboBox SetComboBoxValueAndNext(ContainerControl f, short value) {
      ComboBox cb = f.ActiveControl as ComboBox;
      cb.SelectedValue = value;
      NextControl(f);
      return cb;
    }
    public static ComboBox SetComboBoxValueAndNext(ContainerControl f, int value) {
      ComboBox cb = f.ActiveControl as ComboBox;
      cb.SelectedValue = value;
      NextControl(f);
      return cb;
    }
    public static ComboBox SetComboBoxValueAndNext(ContainerControl f, long value) {
      ComboBox cb = f.ActiveControl as ComboBox;
      cb.SelectedValue = value;
      NextControl(f);
      return cb;
    }
    public static CheckBox SetCheckBoxAndNext(ContainerControl f,bool Value){
    	CheckBox cb = f.ActiveControl as CheckBox;
    	cb.Checked = Value;
    	NextControl(f);
    	return cb;
    }

    public static void PushButtonAndNext(ContainerControl f) {
      Button b = f.ActiveControl as Button;
      b.PerformClick();
      NextControl(f);
    }

	}
}
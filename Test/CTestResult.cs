using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanCruz.Util.Test {
	public class CTestResult {
		public DateTime MomRealizacion;
		public TimeSpan Duracion;
		public bool IsOk;
		public override string ToString() {
			return (IsOk ? "Passed" : "Failed") + " At:" + MomRealizacion.ToShortDateString() + " " + MomRealizacion.ToShortTimeString() + " During " + Duracion.ToString();
		}
	}
}

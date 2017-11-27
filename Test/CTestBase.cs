using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanCruz.Util.Test {
	public abstract class CTestBase<CTestConfigNameClass> {
		public string Name { get; set; }
		public CTestBase(string name) {
			this.Name = name;
		}
		protected CTestResult _LastResult = new CTestResult();
		public CTestResult LastResult { get { return _LastResult; } }

		public abstract void TestIni(CTestConfigNameClass conf);
		public abstract void Test(CTestConfigNameClass conf);
		public abstract void TestFin(CTestConfigNameClass conf);
		public void RunTest(CTestConfigNameClass conf) {
			this.LastResult.MomRealizacion = DateTime.Now;
			this.TestIni(conf);
			try {
				this.Test(conf);
			} finally {
				this.TestFin(conf);
				this.LastResult.Duracion = DateTime.Now.Subtract(this.LastResult.MomRealizacion);
			}
		}
		public override string ToString() {
			return this.Name + " " + this.LastResult.ToString();
		}
	}
}

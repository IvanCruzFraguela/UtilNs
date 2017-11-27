using System.Diagnostics;

namespace IvanCruz.Util.Test {
	public static class SProgramRunner {
		public static Process Run(string exeFilePath, string arguments = null) {
			Process result = new Process();
			result.StartInfo.FileName = exeFilePath;
			result.StartInfo.Arguments = arguments;
			result.Start();
			result.WaitForInputIdle();
			return result;
		}
		public static void Close(Process p) {
			if (p != null) {
				p.CloseMainWindow();
			}
		}
	}
}

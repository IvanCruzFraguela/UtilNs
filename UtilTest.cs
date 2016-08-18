/*
 * Created by SharpDevelop.
 * User: icrufra
 * Date: 05/11/2014
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace es.ivancruz.Utils
{
	[TestClass]
	public class UtilTest
	{
		[TestMethod]
		public void TestDateFromFileString()
		{
			DateTime obtained = Util.DateFromFileString("20141231235959");
			DateTime expected = new DateTime(2014,12,31,23,59,59);
			Assert.AreEqual(expected,obtained);
		}
		[TestMethod]
		public void TestDateToFileString()
		{
			string obtained = Util.DateToFileString(new DateTime(2014,12,31,23,59,59));
			string expected = "20141231235959";
			Assert.AreEqual(expected,obtained);
		}
	}
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x;
            JenkinsProject.Form1 frm = new JenkinsProject.Form1();
            frm.Form1_Load(null,null);
        }
    }
}

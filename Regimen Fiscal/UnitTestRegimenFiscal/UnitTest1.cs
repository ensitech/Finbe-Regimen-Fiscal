using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;

namespace UnitTestRegimenFiscal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var plugin = new Regimen_Fiscal.RegimenFiscal();
            var entity = new Entity();
            entity.Id = new Guid("731F1129-3BDC-EC11-BD3F-0050569D79D0");
            entity.LogicalName = "fib_regimenfiscal";
            plugin.Init(CRMLogin.createService(), new Guid("B437A414-0B33-EA11-8B50-0050569D79D0"), entity, "Update");
        }
    }
}

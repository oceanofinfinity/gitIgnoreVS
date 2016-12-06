using A.Extension.Teamproject.Demo1;
using A.Extension.Teamproject.Demo3;
using A.Extension.Teamproject.Demo3.Impl;
using A.Extension.Teamproject.Demo5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodToLegacyFormat_C20()
        {
            var datetime = new DateTime(1920,12,31);
            Assert.AreEqual("0201231", datetime.ToLegacyFormat());

        }

        [TestMethod]
        public void TestMethodToLegacyFormat_C21()
        {
            var datetime = new DateTime(2013, 12, 31);
            Assert.AreEqual("1131231", datetime.ToLegacyFormat());

        }

        [TestMethod]
        public void TestMethodToLegacyFormat_Str()
        {
            var name = "Anupam Chhipa";
            Assert.AreEqual("CHHIPAANUPAM",name.ToLegacyFormat());

        }
        [TestMethod]
        public void TestXMLDate()
        {
            var date = new DateTime(2013,10,14,13,10,15,951);
            Assert.AreEqual("2013-10-14T13:10:15.951Z",date.ToXMLDate());
        }

        [TestMethod]
        public void TestJsonString()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1  --" + obj1.ToJsonString());

            var obj2 = new DateTime(2013, 12, 24);
            Debug.WriteLine("obj2 ---" + obj2.ToJsonString());


            var obj3 = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3---" + obj3.ToJsonString());

            IEnumerable<IReferenceDataItems> obj4 = new List<IReferenceDataItems> { new SQLReferenceDataSource() };
            Debug.WriteLine("obj4--"+obj4.ToJsonString());
        }

        [TestMethod]
        public void TestTypeJsonString()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1  --" + obj1.GetJsonTypeJsonString());

            var obj2 = new DateTime(2013, 12, 24);
            Debug.WriteLine("obj2 ---" + obj2.GetJsonTypeJsonString());


            var obj3 = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3---" + obj3.GetJsonTypeJsonString());

            IEnumerable<IReferenceDataItems> obj4 = new List<IReferenceDataItems> { new SQLReferenceDataSource() };
            Debug.WriteLine("obj4--" + obj4.GetJsonTypeJsonString());
        }





    }
}

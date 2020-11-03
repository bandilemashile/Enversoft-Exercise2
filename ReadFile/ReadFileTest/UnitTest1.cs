using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadFile;

namespace ReadFileTest
{
    [TestClass]
    public class ReadFileTest
    {
        [TestMethod]
        public void ReadCsv_NotFound(Contact contact)
        {

            //arrange  

            var ReadFileTest = new ReadFileTest();


            //act

            ReadFileTest.ReadCsv_NotFound(new Contact { isFound = true });

            //assert

           



        }

        public void ReadCsv_Found(Contact contact)
        {
            //arrange  

            var ReadFileTest = new ReadFileTest();


            //act

            ReadFileTest.ReadCsv_Found(new Contact { isFound = true });

            //assert

           
        }

        public void WriteCsv_Fail(Contact contact)
        {
            //arrange  

            var ReadFileTest = new ReadFileTest();


            //act

            ReadFileTest.WriteCsv_Fail(new Contact { isFound = true });

            //assert

           

        }

        public void WriteCsv_Pass(Contact contact)
        {
            //arrange  

            var ReadFileTest = new ReadFileTest();


            //act

            ReadFileTest.WriteCsv_Pass(new Contact { isFound = true });

            //assert

            //
         

        }



    }
}

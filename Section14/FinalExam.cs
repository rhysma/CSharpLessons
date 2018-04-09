using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section14
{
    [TestClass]
    [TestCategory("FinalExam")]
    public class FinalExam
    {
        [TestMethod]
        public void Test_ComplicatedPage()
        {
            ComplicatedPage compPage = new ComplicatedPage();
            string pageName = compPage.PageName;
            StringAssert.Equals(pageName, "Complicated Page");
        }

        [TestMethod]
        public void Test_RandomStuff()
        {
            SectionOfRandomStuff random = new SectionOfRandomStuff();
            random.FillForm();
        }

        [TestMethod]
        public void Test_Buttons()
        {
            try
            {
                SectionOfButtons buttons = new SectionOfButtons();
                buttons.Button.Click();
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null reference to the button element " + ex.Message);
            }
           
        }
    }
}

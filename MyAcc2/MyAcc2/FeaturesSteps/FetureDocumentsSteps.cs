using MyAcc2.POM;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyAcc2.FeaturesSteps
{
    [Binding]
    public class FetureDocumentsSteps : DocumentsPagePOM
    {
        [Given(@"User is log in and documents page is opened")]
        public void GivenUserIsLogInAndDocumentsPageIsOpened()
        {
            LogInAndGoToDocumentsPage();
        }
        
        [When(@"I press upload in pasport block")]
        public void WhenIPressUploadInPasportBlock()
        {
            ClickChangePasport();
        }
        
        [When(@"I press upload photo in pasport block")]
        public void WhenIPressUploadPhotoInPasportBlock()
        {
            SendKeysChangePassportPhoto();
            Thread.Sleep(1500);
        }
        
        [When(@"I press upload in adress document block")]
        public void WhenIPressUploadInAdressDocumentBlock()
        {
            ClickChangeAdressDocument();
        }
        
        [When(@"I press upload photo in adress document block")]
        public void WhenIPressUploadPhotoInAdressDocumentBlock()
        {
            SendKeysChangeAdressDocumentPhoto();
            Thread.Sleep(1500);
        }
        
        [When(@"I press upload in additional document block")]
        public void WhenIPressUploadInAdditionalDocumentBlock()
        {
            ClickChangeAdditionalDocument();
        }
        
        [When(@"I press upload photo in additional document block")]
        public void WhenIPressUploadPhotoInAdditionalDocumentBlock()
        {
            SendKeysAdditionalDocumentPhoto();
            Thread.Sleep(1500);
        }
        
        [When(@"I press upload is second additional document block")]
        public void WhenIPressUploadIsSecondAdditionalDocumentBlock()
        {
            Thread.Sleep(2000);
            ClickUploadSecondAdditionalDocument();
        }
        
        [When(@"I press upload second additional  document in second additional document block")]
        public void WhenIPressUploadSecondAdditionalDocumentInSecondAdditionalDocumentBlock()
        {
            SendKeysSecondAdditionalDocumentPhoto();
            Thread.Sleep(1500);
        }

        [When(@"I press upload second additional  document in second additional document block and choose file larger than allowed size")]
        public void WhenIPressUploadSecondAdditionalDocumentInSecondAdditionalDocumentBlockAndChooseFileLargerThanAllowedSize()
        {
            SendKeysSecondAdditionalDocumentPhoto_WithFileLargerThanAllowedSize();
        }


        [Then(@"The result should be name of uploaded file '(.*)' in pasport block")]
        public void ThenTheResultShouldBeNameOfUploadedFileInPasportBlock(string p0)
        {
            string Expected = "Test.jpg";
            string Actual = TextNameOfTheUploadedPasportPhoto();
            Assert.AreEqual(Expected, Actual);
        }
        
        [Then(@"The result should be name of uploaded file '(.*)' in adress document block")]
        public void ThenTheResultShouldBeNameOfUploadedFileInAdressDocumentBlock(string p0)
        {
            string Expected = "Test.jpeg";
            string Actual = TextNameOfTheUploadedAdressDocumentPhoto();
            Assert.AreEqual(Expected, Actual);
        }
        
        [Then(@"The result should be name of uploaded file '(.*)' in additional document block")]
        public void ThenTheResultShouldBeNameOfUploadedFileInAdditionalDocumentBlock(string p0)
        {
            string Expected = "Test.png";
            string Actual = TextNameOfTheUploadedAdditionalDocumentPhoto();
            Assert.AreEqual(Expected, Actual);
        }
        
        [Then(@"The result should be hint under button '(.*)'")]
        public void ThenTheResultShouldBeHintUnderButton(string errorText)
        {
            string Expected = errorText;
            string Actual = TextHintWithErrorMessage();
            Assert.AreEqual(Expected, Actual);
        }

        [After]
        public void DriverQuit()
        {
            Driver.Close();
        }
    }
}

using MyAcc2.Core;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Threading;

namespace MyAcc2.POM
{
    public class DocumentsPagePOM : SeleniumWrapper

    {
        //Log In Page
        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Fields login and password in log in page
        /// </summary>
        internal static By LoginField = By.Id("email");
        internal static By PasswordField = By.Id("password");

        //Documents page 
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Top block of elements
        /// </summary>
        internal static By PersonalCabinet = By.CssSelector(".nav > li:nth-child(1) > a:nth-child(1)");
        internal static By DepositPage = By.CssSelector(".nav > li:nth-child(2) > a:nth-child(1)");
        internal static By ConclusionPage = By.CssSelector(".nav > li:nth-child(3) > a:nth-child(1)");
        internal static By TopBlockPersonalDataPage = By.CssSelector(".nav > li:nth-child(4) > a:nth-child(1)");
        internal static By StateOfAnAccountPage = By.CssSelector(".nav > li:nth-child(5) > a:nth-child(1)");
        internal static By PromoActionsPage = By.CssSelector(".nav > li:nth-child(6) > a:nth-child(1)");
        internal static By DocumentsPage = By.CssSelector(".nav > li:nth-child(7) > a:nth-child(1)");
        internal static By SignOut = By.CssSelector(".pull-right");

        /// <summary>
        /// Left block of elements
        /// </summary>
        internal static By LeftBlockPersonalDataPage = By.CssSelector("#sub-menu > a:nth-child(1)");
        internal static By LeftBlockDocumentsPage = By.CssSelector("#sub-menu > a:nth-child(2)");
        internal static By SecurityPage = By.CssSelector("#sub-menu > a:nth-child(3)");

        /// <summary>
        /// Passport photo loading unit
        /// </summary>
        internal static By UploadPasport = By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button");
        internal static By UploadPasportPhoto = By.CssSelector("div:nth-child(1) > div > div input");
        internal static By WhatShouldBeAPasport = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangePassport = By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button");
        internal static By ChangePassportPhoto = By.CssSelector("div:nth-child(1) > div > div input"); 

        /// <summary>
        /// Adress Document loading unit
        /// </summary>
        internal static By UploadAdressDocument = By.CssSelector("div:nth-child(2) > div > div:nth-child(3) > button");
        internal static By UploadAdressDocumnetPhoto = By.CssSelector("div:nth-child(2) > div > div input");
        internal static By WhatShouldBeAAdressDocument = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdressDocument = By.CssSelector("div:nth-child(2) > div > div:nth-child(3) > button");
        internal static By ChangeAdressDocumentPhoto = By.CssSelector("div:nth-child(2) > div > div input"); 

        /// <summary>
        /// Additional Document loading unit
        /// </summary>
        internal static By UploadAdditionalDocument = By.CssSelector("div:nth-child(3) > div > div:nth-child(3) > button");
        internal static By UploadAdditionalDocumnetPhoto = By.CssSelector("div:nth-child(3) > div > div input");
        internal static By WhatShouldBeAAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdditionalDocument = By.CssSelector("div:nth-child(3) > div > div:nth-child(3) > button");
        internal static By ChangeAdditionalDocumentPhoto = By.CssSelector("div:nth-child(3) > div > div input");

        /// <summary>
        /// Second Additional Document loading unit
        /// </summary>
        internal static By UploadSecondAdditional = By.CssSelector("div:nth-child(4) > div > div:nth-child(3) > button");
        internal static By UploadSecondAdditionalPhoto = By.CssSelector("div:nth-child(4) > div > div input");
        internal static By WhatShouldBeASecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By HintWithErrorMessage = By.CssSelector(".validation-errors");
        internal static By NameOfTheUploadedSecondAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadSecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeSecondAdditionalDocument = By.CssSelector("div:nth-child(4) > div > div:nth-child(3) > button");
        internal static By ChangeSecondAdditionalDocumentPhoto = By.CssSelector("div:nth-child(4) > div > div input");

        //Account status page
        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Account status page
        /// </summary>
        internal static By ChoiceTradingAccount = By.CssSelector("select.form-control");
        internal static By StartDdate = By.Id("start-date");
        internal static By StartDdateIcon = By.CssSelector("span.form-group:nth-child(1) > span:nth-child(1) > span:nth-child(2) > span:nth-child(2)");
        internal static By EndDate = By.Id("end-date");
        internal static By EndDateIcon = By.CssSelector("span.form-group:nth-child(2) > span:nth-child(1) > span:nth-child(2) > span:nth-child(2)");
        internal static By ShowAccountStatus = By.CssSelector("button.btn:nth-child(3)");
        internal static By DownloadTransactionDocument = By.CssSelector("button.btn:nth-child(4)");
        internal static By NameOfTheTradingPlatform = By.CssSelector(".information-block > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > b:nth-child(1)");
        internal static By NameOfTheLogin = By.CssSelector(".text-truncate > b:nth-child(1)");
        internal static By AccountStatementsText = By.CssSelector(".margin-bottom");
        internal static By StatementsText = By.CssSelector("div.margin-top-large > h4:nth-child(1)");
        internal static By ShowReport = By.CssSelector("button.btn:nth-child(3)");


        //Login page methods
        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// This metod input email in login field
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysLoginField()
        {
            FindElement(LoginField).SendKeys("qwerty@com.ua");
            return this;
        }

        /// <summary>
        /// This method input password in password field and press "Enter"
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysPasswordField()
        {
            FindElement(PasswordField).SendKeys("123qwe" + Keys.Enter);
            return this;
        }

        //Open pages methods
        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method open Documents page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM OpenDocumentsPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/?lang=en#documents");
            return this;
        }

        /// <summary>
        /// This method open Account status page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM OpenAccountStatusPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/?lang=ru#account-status");
            return this;
        }

        //Documents page methods
        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method open Personal cabinet page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalCabinet()
        {
            FindElement(PersonalCabinet).Click();
            return this;
        }

        /// <summary>
        /// This method open Deposit page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickDepositPage()
        {
            FindElement(DepositPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Conclusion page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickConclusionPage()
        {
            FindElement(ConclusionPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal data page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickTopBlockPersonalDatasPage()
        {
            FindElement(TopBlockPersonalDataPage).Click();
            return this;
        }

        /// <summary>
        /// This method open State of an account page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickStateOfAnAccountPage()
        {
            FindElement(StateOfAnAccountPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Promo actions page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPromoActionsPage()
        {
            FindElement(PromoActionsPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Documents page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickDocumentsPage()
        {
            FindElement(DocumentsPage).Click();
            return this;
        }

        /// <summary>
        /// This method is logged out
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickSignOut()
        {
            FindElement(SignOut).Click();
            return this;
        }

        /// <summary>
        /// This method open Left block personal data page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickLeftBlockPersonalData()
        {
            FindElement(LeftBlockPersonalDataPage).Click();
            return this;
        }

        /// <summary>
        /// This method open left block documents page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickLeftBlockDocumentsPage()
        {
            FindElement(LeftBlockDocumentsPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Security page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickSecurityPage()
        {
            FindElement(SecurityPage).Click();
            return this;
        }
        
        /// <summary>
        /// This method displays validation for uploading pasport photo.
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickWhatShouldBeAPasport()
        {
            FindElement(WhatShouldBeAPasport).Click();
            return this;
        }

        /// <summary>
        /// This method Open block upload pasport photo 
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickChangePasport()
        {
            FindElement(ChangePassport).Click();
            return this;
        }

        /// <summary>
        /// This method upload pasport photo
        /// </summary>
        /// <returns></returns>
        
        public DocumentsPagePOM SendKeysChangePassportPhoto()
        {
            
            FindElement(ChangePassportPhoto).SendKeys(System.IO.Directory.GetCurrentDirectory() + "\\MyAcc2\\FilesForUpload\\Test.jpg"); 
            return this;
        }

        /// <summary>
        /// This method save the name of the uploaded pasport photo
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheUploadedPasportPhoto()
        {
            string Actual = FindElement(NameOfTheUploadedPasportPhoto).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method Open block upload adress document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickChangeAdressDocument()
        {
            FindElement(ChangeAdressDocument).Click();
            return this;
        }

        /// <summary>
        /// This method upload adress document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysChangeAdressDocumentPhoto()
        {
            FindElement(ChangeAdressDocumentPhoto).SendKeys(System.IO.Directory.GetCurrentDirectory() + "\\MyAcc2\\FilesForUpload\\Test.jpeg");
            return this;
        }

        /// <summary>
        /// This method save the name of the uploaded adress document photo
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheUploadedAdressDocumentPhoto()
        {
            string Actual = FindElement(NameOfTheUploadedAdressDocumentPhoto).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method Open block upload additional document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickChangeAdditionalDocument()
        {
            FindElement(ChangeAdditionalDocument).Click();
            return this;
        }

        /// <summary>
        /// This method upload additional document document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysAdditionalDocumentPhoto()
        {
            FindElement(ChangeAdditionalDocumentPhoto).SendKeys(System.IO.Directory.GetCurrentDirectory() + "\\MyAcc2\\FilesForUpload\\Test.png");
            return this;
        }

        /// <summary>
        /// This method save the name of the uploaded additional document photo
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheUploadedAdditionalDocumentPhoto()
        {
            string Actual = FindElement(NameOfTheUploadedAdditionalDocumentPhoto).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method Open block download second additional document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickUploadSecondAdditionalDocument()
        {
            Thread.Sleep(3000);
            FindElement(UploadSecondAdditional).Click();
            return this;
        }

        /// <summary>
        /// This method upload second additional document document photo
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysSecondAdditionalDocumentPhoto()
        {
            FindElement(UploadSecondAdditionalPhoto).SendKeys(System.IO.Directory.GetCurrentDirectory() + "\\MyAcc2\\bin\\Debug\\BoDi.dll");
            return this;
        }

        /// <summary>
        /// This method save the name of the uploaded second additional document photo
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheUploadedSecondAdditionmalDocumentPhoto()
        {
            string Actual = FindElement(NameOfTheUploadedSecondAdditionalDocumentPhoto).Text.ToString();
            return Actual;
        }

        //Account status page methods
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method save the name of the uploaded second additional document photo
        /// </summary>
        /// <returns></returns>
        public string TextHintWithErrorMessage()
        {
            string Actual = FindElement(HintWithErrorMessage).Text.ToString();
            return Actual;
        }

        public DocumentsPagePOM SendKeysSecondAdditionalDocumentPhoto_WithFileLargerThanAllowedSize()
        {
            FindElement(UploadSecondAdditionalPhoto).SendKeys(System.IO.Directory.GetCurrentDirectory() + "\\MyAcc2\\bin\\Debug\\chromedriver.exe");
            return this;
        }

        /// <summary>
        /// This nethod input date in start date field
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysToStartDate()
        {
            FindElement(StartDdate).SendKeys("MethodDDMMYY");
            return this;
        }

        /// <summary>
        /// This nethod input date in end date field
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeysToEndDate()
        {
            FindElement(EndDate).SendKeys("MethodDDMMYY");
            return this;
        }

        /// <summary>
        /// This method save the choiced account my transactions
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheLogin()
        {
            string Actual = FindElement(NameOfTheLogin).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method save the choiced traiding platform my transactions
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheTradingPlatform()
        {
            string Actual = FindElement(NameOfTheTradingPlatform).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method save the start date and end date of my transactions
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheStatements()
        {
            string Actual = FindElement(StatementsText).Text.ToString();
            return Actual;
        }

        /// <summary>
        /// This method save the start date and end date of my transactions
        /// </summary>
        /// <returns></returns>
        public string TextNameOfTheAccountStatements()
        {
            string Actual = FindElement(AccountStatementsText).Text.ToString();
            return Actual;
        }

        // Cookie methods
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Next Methods for save login and password in cookie
        /// </summary>
        public ReadOnlyCollection<Cookie> cookie;

        public ReadOnlyCollection<Cookie> GetAuthCookie()
        {
            if (cookie != null)
            {
                CreateAuthCookie();
            }
            return cookie;
        }

        public ReadOnlyCollection<Cookie> CreateAuthCookie()
        {
            return cookie = Driver.Manage().Cookies.AllCookies;
        }
        
        public DocumentsPagePOM SetAuthCookie()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            foreach (Cookie c in cookie)
            {
                Driver.Manage().Cookies.AddCookie(c);
            }
            return this;
        }

        /// <summary>
        /// This method open browser, log in in My Account
        /// </summary>
        public void LogIn()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/#login");
            Thread.Sleep(3000);
            SendKeysLoginField();
            SendKeysPasswordField();
            Thread.Sleep(1500);
            cookie = Driver.Manage().Cookies.AllCookies;
        }
        
        /// <summary>
        /// This method open browser, log in in My Account and go to documents page
        /// </summary>
        public void LogInAndGoToDocumentsPage()
        {
            LogIn();
            Driver.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/?lang=en#documents");
            Driver.Manage().Cookies.DeleteAllCookies();
            foreach (Cookie c in cookie)
            {
                Driver.Manage().Cookies.AddCookie(c);
            }
            Driver.Navigate().Refresh();
            Thread.Sleep(4500);
        }

        /// <summary>
        /// This method open browser, log in in My Account and go to account status page
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM LogInAndGoToAccStatus()
        {
            LogIn();
            Driver.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/?lang=en#account-status");
            Driver.Manage().Cookies.DeleteAllCookies();
            foreach (Cookie c in cookie)
            {
                Driver.Manage().Cookies.AddCookie(c);
            }
            Driver.Navigate().Refresh();
            Thread.Sleep(3500);
            return this;
        }

    }
}
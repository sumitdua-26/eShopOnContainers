// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Login_EShopApplicationSteps.cs" company="Microsoft">
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//    OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EShopApplicationWebSolution.StepDefinitions
{
    using System.Configuration;
    using System.Threading;
    using Bdd.Core.Web.Executors;
    using Bdd.Core.Web.StepDefinitions;
    using Bdd.Core.Web.Utils;
    using EShopApplicationWebSolution.Properties;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;

    [Binding]
    public class Login_EShopApplicationSteps : WebStepDefinitionBase
    {
        [When(@"user launches EShop application")]
        public void WhenUserLaunchesEShopApplication()
        {
            this.DriverContext.Get<UrlPage>().NavigateToUrl(ConfigurationManager.AppSettings.Get("url"));
            this.Get<ElementPage>().WaitUntilPageLoad();
        }

        [When(@"user clicks on ""(.*)"" button")]
        public void WhenUserClicksOnButton(string element)
        {
            Thread.Sleep(2000);
            IWebElement elementToClick = this.Get<ElementPage>().FindElementByXPath(element);
            elementToClick.Click();
            this.Get<ElementPage>().WaitUntilPageLoad();
        }

        [When(@"user enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersEmailAndPassword(string element1, string element2)
        {
            IWebElement emailField = this.Get<ElementPage>().FindElementById(Resources.ResourceManager.GetString(element1));
            emailField.SendKeys(ConfigurationManager.AppSettings.Get("userEmail"));

            IWebElement passwordField = this.Get<ElementPage>().FindElementById(Resources.ResourceManager.GetString(element2));
            passwordField.SendKeys(ConfigurationManager.AppSettings.Get("userPassword"));
        }

        [Then(@"user should be logged-in")]
        public void ThenVerifyIfUserIsLogged_In()
        {
            IWebElement isUserLoggedIn = this.Get<ElementPage>().FindElementByXPath("LoggedInUser");
            string loggedInUserId = isUserLoggedIn.Text;

            Assert.AreEqual(loggedInUserId, ConfigurationManager.AppSettings.Get("userEmail"), $"Login Falied");
        }

        [Then(@"the user should not be able to login to the application")]
        public void ThenTheUserShouldNotBeAbleToLoginToTheApplication()
        {

        }
    }
}

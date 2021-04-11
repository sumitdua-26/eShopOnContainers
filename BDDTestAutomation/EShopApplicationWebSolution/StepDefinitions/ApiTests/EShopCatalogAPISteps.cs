// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EShopCatalogAPISteps.cs" company="Microsoft">
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//    OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EShopApplicationWebSolution.StepDefinitions.ApiTests
{
    using System;
    using System.Configuration;
    using System.Net.Http;
    using Bdd.Core.Api.StepDefinitions;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public class EShopCatalogAPISteps : ApiStepDefinitionBase
    {
        private string endpoint;
        private string url;
        private HttpResponseMessage httpResponse;
        private JObject responseObject;

        [Given(@"user wants to get Catalog types")]
        [Given(@"user wants to get catalog items")]
        public void GivenUserWantsToGetCatalog()
        {
            this.endpoint = ConfigurationManager.AppSettings.Get("EShopEndpoint");
        }

        [When(@"""(.*)"" API is called")]
        public async System.Threading.Tasks.Task WhenAPIIsCalledAsync(string apiName)
        {
            this.url = this.endpoint + ConfigurationManager.AppSettings.Get(apiName.Replace(" ", ""));

            this.httpResponse = await this.ApiExecutor.GetResponseAsync(this.url, this.UserDetails);

            this.ScenarioContext["responsestatuscode"] = (int)this.httpResponse.StatusCode;
            this.ScenarioContext["jsonResponse"] = await this.httpResponse.Content.ReadAsStringAsync();
        }

        [When(@"the page index is (.*)")]
        public void WhenThePageIndexIs(int pageIndex)
        {
            
        }

        [When(@"the page size is (.*)")]
        public void WhenThePageSizeIs(int pageSize)
        {
            
        }

        [Then(@"the api should return ""(.*)"" response")]
        public void ThenTheApiShouldReturnResponse(int httpResponseCode)
        {
            Assert.AreEqual(httpResponseCode, this.ScenarioContext["responsestatuscode"]);
        }

        [Then(@"the user should be able to get catalog types")]
        public void ThenTheUserShouldBeAbleToGetCatalogTypes()
        {
            
        }

        [Then(@"the user should be able to get catalog items for the given page")]
        public void ThenTheUserShouldBeAbleToGetCatalogItemsForTheGivenPage()
        {
            
        }
    }
}

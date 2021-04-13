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

namespace EShopApplicationWebSolution.StepDefinitions
{
    using System;
    using System.Configuration;
    using System.Net.Http;
    using Bdd.Core.Api.StepDefinitions;
    using EShopApplicationWebSolution.Constants;
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

        [Given(@"user wants to get Catalog types through ""(.*)"" API")]
        [Given(@"user wants to get catalog items through ""(.*)"" API")]
        public void GivenUserWantsToGetCatalog(string apiName)
        {
            this.endpoint = ConfigurationManager.AppSettings.Get("EShopEndpoint");
            this.url = this.endpoint + ConfigurationManager.AppSettings.Get(apiName.Replace(" ", ""));
        }

        [When(@"catalog types API is called")]
        [When(@"catalog items API is called")]
        public async System.Threading.Tasks.Task WhenAPIIsCalledAsync()
        {
            this.httpResponse = await this.ApiExecutor.GetResponseAsync(this.url, this.UserDetails);

            this.ScenarioContext["responsestatuscode"] = (int)this.httpResponse.StatusCode;
            this.ScenarioContext["jsonResponse"] = await this.httpResponse.Content.ReadAsStringAsync();
        }

        [When(@"the ""(.*)"" is ""(.*)""")]
        public void WhenThePageIndexIs(string parameterName, string parameterValue)
        {
            this.url = this.AppendParameterToURL(parameterName, parameterValue);
        }

        [Then(@"the api should return ""(.*)"" response")]
        public void ThenTheApiShouldReturnResponse(int httpResponseCode)
        {
            Assert.AreEqual(httpResponseCode, this.ScenarioContext["responsestatuscode"]);
        }

        [Then(@"the user should be able to get catalog types")]
        public void ThenTheUserShouldBeAbleToGetCatalogTypes()
        {
            JArray catalogTypes = JArray.Parse(this.ScenarioContext.Get<string>("jsonResponse"));
            Assert.AreEqual(catalogTypes.Count, Constants.catalogTypeCount);
        }

        [Then(@"response should return pageSize as (.*)")]
        public void ThenResponseShouldReturnPagesizeAs(int pageSize)
        {
            JObject catalogueItems = JObject.Parse(this.ScenarioContext.Get<string>("jsonResponse"));
            Assert.AreEqual(Convert.ToInt32(catalogueItems.SelectToken("$.pageSize")), pageSize);
        }

        [Then(@"response should return pageIndex as (.*)")]
        public void ThenResponseShouldReturnPageIndexAs(int pageIndex)
        {
            JObject catalogueItems = JObject.Parse(this.ScenarioContext.Get<string>("jsonResponse"));
            Assert.AreEqual(Convert.ToInt32(catalogueItems.SelectToken("$.pageIndex")), pageIndex);
        }

        private string AppendParameterToURL(string parameterName, string parameterValue)
        {
            string url;
            string entityToAppend = parameterName.Replace(" ", "") + "=" + parameterValue;
            url = this.url + entityToAppend + "&";

            return url;
        }
    }
}

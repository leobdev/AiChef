using AiChef.Server.Services;
using AiChef.Server.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiChef.Tests
{
    [TestClass]
    public class OpenAIServiceTests
    {


        [TestMethod]
        public void Test_CreateRecipeIdeas_API_Call()
        {
            //Arrange
            string mealtime = "Breakfast";
            List<string> ingredients = new List<string>()
            {
                 "butter",
                 "bread",
                 "eggs",
                 "bacon",
                 "milk",
                 "sour cream"

            };

            var appsettings = new Dictionary<string, string>()
            {
                {"OpenAi:OpenAiKey", "YmMb55XDlxjpc06wNPh0T3BlbkFJm0GHqFHXTnlLbCjUeyY8"},

            };

            IConfiguration config = new ConfigurationBuilder().AddInMemoryCollection(appsettings).Build();
            IOpenAIAPI service = new OpenAIService(config);

            //Action
            var response = service.CreateRecipeIdeas(mealtime, ingredients);

            //Assert
            Assert.IsTrue(response.Result.Any());


        }
    }
}

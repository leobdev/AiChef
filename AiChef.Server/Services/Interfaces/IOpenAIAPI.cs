using AiChef.Shared;

namespace AiChef.Server.Services.Interfaces
{
    public interface IOpenAIAPI
    {
        Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);
    }
}

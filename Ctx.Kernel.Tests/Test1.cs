using System;
using System.Threading.Tasks;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.CoreSkills;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ctx.Kernel.Tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public async Task Test_LLM_Integration()
        {
            // Arrange: Create a new kernel instance
            var kernel = Kernel.Builder.Build();

            // Replace with your OpenAI API key, or better yet, store it securely (e.g., as an environment variable)
            const string openAiApiKey = "YOUR_OPENAI_API_KEY";
            const string modelName = "text-davinci-003"; // Example OpenAI Model

            // Register OpenAI
            kernel.Config.AddOpenAITextCompletion("OpenAI", modelName, openAiApiKey);

            // Define a simple prompt template for testing
            const string prompt = "Write a poem about the stars";

            // Act: Call the LLM to create a completion
            var completion = await kernel.RunAsync(prompt);

            // Assert: Verify the result (not null or empty)
            Assert.IsNotNull(completion.Result, "LLM failed to generate a response.");
            Assert.IsTrue(completion.Result.Length > 0, "LLM produced an empty response.");

            // Output for debugging (optional)
            Console.WriteLine("Generated text: " + completion.Result);
        }
    }
}
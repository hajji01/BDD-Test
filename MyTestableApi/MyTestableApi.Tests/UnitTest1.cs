using Xunit;
using MyTestableApi.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyTestableApi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestScenarioRecherchePIBParPays()
        {
            // Préparer l'environnement de test
            var controller = new PIBController();

            // Agir sur le système sous test
            var result = controller.GetPIBData("France");

            // Vérifier les résultats de l'action
            var okResult = Assert.IsType<OkObjectResult>(result);
            var data = Assert.IsType<System.Collections.Generic.Dictionary<int, double>>(okResult.Value);
            Assert.NotEmpty(data);
        }

        [Fact]
        public void TestScenarioCollectePIB()
        {
            // Préparer l'environnement de test
            var controller = new PIBController();

            // Agir sur le système sous test
            var result = controller.CollecterPIBData("USA", 2022);

            // Vérifier les résultats de l'action
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Données du PIB pour USA en 2022 collectées avec succès.", okResult.Value);
        }
    }
}

// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.LondonDataService.Infrastructure.Services;

namespace LondonFhirService.Providers.FHIR.R4.LondonDataService.Infrastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scriptGenerationService = new ScriptGenerationService();

            scriptGenerationService.GenerateBuildScript(
                branchName: "main",
                projectName: "LondonFhirService.Providers.FHIR.R4.LondonDataService",
                dotNetVersion: "9.0.100");

            scriptGenerationService.GeneratePrLintScript(branchName: "main");
        }
    }
}

using System.Collections.Generic;
using BlazorWasm.Models;

namespace BlazorWasm.Data
{
    interface IPlanetService
    {
        IEnumerable<Planet> GetPlanets(string filter = null);

        bool AddPlanet(Planet planet);

        bool UpdatePlanet(Planet inputPlanet, Planet editPlanet);
    }
}

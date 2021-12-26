using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace HobbyWebsite.Pages
{
    public partial class CatFactsComponent
    {
        private RandomCatFact _json = new RandomCatFact();

        protected override async Task OnInitializedAsync()
        {
            _json = await Http.GetFromJsonAsync<RandomCatFact>("https://catfact.ninja/fact");
        }
    }

    public class RandomCatFact
    {
        public string Fact { get; set; }

        public int Length { get; set; }
    }
}
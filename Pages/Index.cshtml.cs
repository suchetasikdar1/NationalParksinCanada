using Microsoft.AspNetCore.Mvc.RazorPages;
using CanadianNationalParks.Models;
using CanadianNationalParks.Data;
using System.Collections.Generic;

namespace CanadianNationalParks.Pages
{
    public class IndexModel : PageModel
    {
        public List<NationalPark> NationalParks { get; set; }

        public void OnGet()
        {
            NationalParks = ParkRepository.GetAllParks();
        }
    }
}

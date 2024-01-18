namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List <CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The big apple."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the unfinished cathedral."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Has that big tower."
                }
            };
        }
    }
}

using lesson_5.Services;

namespace lesson_5.Services;

public interface ICountryService
{
    Guid AddCountry(Country country);
    bool UpdateCountry(Country country);
    bool DeleteCountry(Guid countryId);
    Country? GetCountryById(Guid countryId);
    List<Country> GetAllCountries();
}


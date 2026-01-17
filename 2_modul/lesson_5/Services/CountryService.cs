namespace lesson_5.Services;


public class CountryService : ICountryService
{
    List<Country> Countries;

    public CountryService()
    {
        Countries = new List<Country>();
    }

    public Guid AddCountry(Country country)
    {
        country.CountryId = Guid.NewGuid();
        Countries.Add(country);
        return country.CountryId;
    }

    public bool DeleteCountry(Guid countryId)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == countryId)
            {
                Countries.Remove(country);
                return true;
            }
        }
        return false;
    }

    public List<Country> GetAllCountries()
    {
        return Countries;
    }

    public Country? GetCountryById(Guid countryId)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == countryId)
            {
                return country;
            }
        }
        return null;
    }

    public bool UpdateCountry(Country updatingCountry)
    {
        foreach (var country in Countries)
        {
            if (country.CountryId == updatingCountry.CountryId)
            {
                country.Name = updatingCountry.Name;
                country.Code = updatingCountry.Code;
                return true;
            }
        }
        return false;
    }
}


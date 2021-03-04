using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belize
    /// </summary>
    public class BelizeCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Belize";
        ///<inheritdoc/>
        public string OfficialName => "Belize";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BZ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BLZ;
        ///<inheritdoc/>
        public int NumericCode => 084;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bz" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.MX,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BzdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "501" };
    }
}

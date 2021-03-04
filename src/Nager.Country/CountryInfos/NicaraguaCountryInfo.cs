using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nicaragua
    /// </summary>
    public class NicaraguaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Nicaragua";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Nicaragua";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NI;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NIC;
        ///<inheritdoc/>
        public int NumericCode => 558;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ni" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CR,
            Alpha2Code.HN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NioCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "505" };
    }
}

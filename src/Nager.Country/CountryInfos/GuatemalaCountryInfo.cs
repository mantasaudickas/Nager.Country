using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guatemala
    /// </summary>
    public class GuatemalaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Guatemala";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Guatemala";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GT;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GTM;
        ///<inheritdoc/>
        public int NumericCode => 320;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".gt" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BZ,
            Alpha2Code.SV,
            Alpha2Code.HN,
            Alpha2Code.MX,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new GtqCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "502" };
    }
}

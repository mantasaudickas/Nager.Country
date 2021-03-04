using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Japan
    /// </summary>
    public class JapanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Japan";
        ///<inheritdoc/>
        public string OfficialName => "Japan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.JP;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.JPN;
        ///<inheritdoc/>
        public int NumericCode => 392;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".jp", ".みんな" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new JpyCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "81" };
    }
}

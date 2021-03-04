using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lebanon
    /// </summary>
    public class LebanonCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Lebanon";
        ///<inheritdoc/>
        public string OfficialName => "Lebanese Republic";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LB;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LBN;
        ///<inheritdoc/>
        public int NumericCode => 422;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".lb" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.SY,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new LbpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "961" };
    }
}

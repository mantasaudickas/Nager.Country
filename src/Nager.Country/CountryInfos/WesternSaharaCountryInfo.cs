using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Western Sahara
    /// </summary>
    public class WesternSaharaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Western Sahara";
        ///<inheritdoc/>
        public string OfficialName => "Sahrawi Arab Democratic Republic";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.EH;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ESH;
        ///<inheritdoc/>
        public int NumericCode => 732;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".eh" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.MR,
            Alpha2Code.MA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new MadCurrency(), new DzdCurrency(), new MroCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "212" };
    }
}

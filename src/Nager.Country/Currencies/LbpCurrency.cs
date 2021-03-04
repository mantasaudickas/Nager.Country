namespace Nager.Country.Currencies
{
    public class LbpCurrency : ICurrency
    {
        public string Symbol => "ل.ل.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "LBP";

        ///<inheritdoc/>
        public string NumericCode => "422";

        ///<inheritdoc/>
        public string Name => "Lebanese Pound";
    }
}

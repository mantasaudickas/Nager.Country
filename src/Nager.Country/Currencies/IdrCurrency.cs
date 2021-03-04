namespace Nager.Country.Currencies
{
    public class IdrCurrency : ICurrency
    {
        public string Symbol => "Rp";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "IDR";

        ///<inheritdoc/>
        public string NumericCode => "360";

        ///<inheritdoc/>
        public string Name => "Indonesian Rupiah";
    }
}

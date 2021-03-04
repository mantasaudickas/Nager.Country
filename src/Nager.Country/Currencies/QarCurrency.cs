namespace Nager.Country.Currencies
{
    public class QarCurrency : ICurrency
    {
        public string Symbol => "ر.ق.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "QAR";

        ///<inheritdoc/>
        public string NumericCode => "634";

        ///<inheritdoc/>
        public string Name => "Qatari Rial";
    }
}

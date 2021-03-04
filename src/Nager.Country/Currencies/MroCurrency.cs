namespace Nager.Country.Currencies
{
    public class MroCurrency : ICurrency
    {
        public string Symbol => "UM";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MRO";

        ///<inheritdoc/>
        public string NumericCode => "478";

        ///<inheritdoc/>
        public string Name => "	Mauritanian ouguiya";
    }
}

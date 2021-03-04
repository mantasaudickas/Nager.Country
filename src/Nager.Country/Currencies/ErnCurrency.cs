﻿namespace Nager.Country.Currencies
{
    public class ErnCurrency : ICurrency
    {
        public string Symbol => "Nfk";

        ///<inheritdoc/>
        public string Singular => "nakfa";

        ///<inheritdoc/>
        public string Plural => "nakfa";

        ///<inheritdoc/>
        public string IsoCode => "ERN";

        ///<inheritdoc/>
        public string NumericCode => "232";

        ///<inheritdoc/>
        public string Name => "Eritrean nakfa";
    }
}

﻿namespace Nager.Country.Currencies
{
    public class CveCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "escudo";

        ///<inheritdoc/>
        public string Plural => "escudo";

        ///<inheritdoc/>
        public string IsoCode => "CVE";

        ///<inheritdoc/>
        public string NumericCode => "132";

        ///<inheritdoc/>
        public string Name => "Cape Verdean escudo";
    }
}

﻿#nullable enable
using System;
using System.Collections.Generic;
using System.Globalization;

namespace UnitsNet.Tests
{
    internal class DummyIQuantity : IQuantity
    {
        public BaseDimensions Dimensions => throw new NotImplementedException();

        public QuantityInfo QuantityInfo => throw new NotImplementedException();

        public Enum Unit => throw new NotImplementedException();

        public QuantityValue Value => throw new NotImplementedException();

        public double As(Enum unit ) => throw new NotImplementedException();

        public double As(UnitSystem unitSystem ) => throw new NotImplementedException();

        public string ToString(IFormatProvider? provider) => throw new NotImplementedException();

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public IQuantity ToUnit(Enum unit, UnitConverter unitConverter) => throw new NotImplementedException();

        public IQuantity ToUnit(Enum unit ) => throw new NotImplementedException();

        public IQuantity ToUnit(UnitSystem unitSystem ) => throw new NotImplementedException();

        public IReadOnlyList<string> GetAbbreviations(CultureInfo? culture = null) => throw new NotImplementedException();
    }
}

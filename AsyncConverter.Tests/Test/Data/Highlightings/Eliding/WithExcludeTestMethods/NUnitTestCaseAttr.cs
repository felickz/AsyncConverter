﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    using NUnit.Framework;
    public class Class
    {
        [TestCase]
        public async Task Test()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
    }
}

namespace NUnit.Framework
{
    public class TestCaseAttribute : Attribute
    { }
}
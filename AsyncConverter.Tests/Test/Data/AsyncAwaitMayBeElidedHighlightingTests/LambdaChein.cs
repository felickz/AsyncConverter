﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public Task TestAsync()
        {
            return Task.Factory.StartNew(async () => (await MethodAsync().ConfigureAwait(false)).Method());
        }

        public Task<Class> MethodAsync()
        {
            return Task.FromResult<Class>(null);
        }

        public void Method()
        {
        }
    }
}

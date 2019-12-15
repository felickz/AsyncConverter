﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task<int> TestAsync()
        {
            var a = await Task.FromResult(1000).ContinueWith(task => task.Result).ConfigureAwait(false);
            return a;
        }
    }
}
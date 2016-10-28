﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public void Method()
        {
            var integer = 5;
            var a = MethodAsync({caret}integer);
        }

        public int MethodAsync(Task<int> taskInt)
        {
            return taskInt.Result;
        }

    }
}

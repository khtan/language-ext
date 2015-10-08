﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    public interface ILinqDisposable : IDisposable
    {
    }

    public class LinqDisposable<T> 
        where T : IDisposable
    {
        public readonly T Value;

        internal LinqDisposable(T value)
        {
            Value = value;
        }

        public void Dispose()
        {
        }
    }
}
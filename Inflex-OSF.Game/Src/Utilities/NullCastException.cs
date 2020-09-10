#nullable enable
using System;

namespace Game.Game.Utilities
{
    public class NullCastException : Exception
    {
        public NullCastException()
        {
        }

        public NullCastException(string? message)
            : base(message)
        {
        }

        public NullCastException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
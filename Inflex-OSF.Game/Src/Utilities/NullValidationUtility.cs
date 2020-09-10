using System;
using JetBrains.Annotations;

namespace Game.Game.Utilities
{
    public static class NullValidationUtility
    {
        [NotNull]
        [return: System.Diagnostics.CodeAnalysis.NotNull]
        public static T ArgumentNotNull<T>([CanBeNull]this T t, string name)
        {
            if (t is null)
            {
                throw new ArgumentNullException(name);
            }

            return t;
        }

        [NotNull]
        [return: System.Diagnostics.CodeAnalysis.NotNull]
        public static T CastNotNull<T>([CanBeNull]this T t, string name)
        {
            if (t is null)
            {
                throw new NullCastException(name);
            }

            return t;
        }
    }
}
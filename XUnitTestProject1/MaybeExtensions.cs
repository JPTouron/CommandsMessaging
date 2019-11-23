using CommandExecutor;
using CommandExecutor.Functional;

namespace XUnitTestProject1
{
    /// <summary>
    /// this class only within unit tests scope as to ease-in assertions for maybe types and bypass the whole getvalueordefault thingy 
    /// and replace it with a simpler Value() call
    /// </summary>
    public static class MaybeExtensions
    {
        public static T Value<T>(this Maybe<T> maybe)
        {
            return maybe.GetValueOrDefault(default(T));
        }

        public static int? Value(this Maybe<int?> maybe)
        {
            return maybe.GetValueOrDefault(0);
        }

        public static string Value(this Maybe<string> maybe)
        {
            return maybe.GetValueOrDefault("Default Value");
        }
    }
}
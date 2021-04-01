#nullable enable

namespace ScopeFunctions
{
    public static class ObjectExtensions 
    {
        public static R Let<T, R>(this T self, System.Func<T, R> block) 
        {
            return block(self);
        }

        public static T Also<T>(this T self, System.Action block)
        {
            block();
            return self;
        }

        public static T Also<T>(this T self, System.Action<T> block)
        {
            block(self);
            return self;
        }

        public static T  ElseThrow<T, E>(this T self, E exception) where E : System.Exception {
            return self ?? throw exception;
        }
    }
}
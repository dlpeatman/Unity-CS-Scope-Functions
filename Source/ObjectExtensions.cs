#nullable enable

using System;

namespace ScopeFunctions
{
    static class ObjectExtensions 
    {
        public static R Let<T, R>(this T self, Func<T, R> block) 
        {
            return block(self);
        }

        public static T Also<T>(this T self, Action block)
        {
            block();
            return self;
        }

        public static T Also<T>(this T self, Action<T> block)
        {
            block(self);
            return self;
        }

        public static T  ElseThrow<T, E>(this T self, E exception) where E : Exception {
            return self ?? throw exception;
        }
    }
}
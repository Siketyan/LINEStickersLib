using System;

namespace LINEStickersLib.Exceptions
{
    public class StickersAPIException : Exception
    {
        public StickersAPIException(string message) : base(message) {}
    }
}
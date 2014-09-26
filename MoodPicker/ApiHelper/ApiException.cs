using System;

namespace MoodPicker.ApiHelper
{

    public class ApiException : Exception
    {
        private int error;
        public int Error { get { return error; } }

        public ApiException(string message, int error) : base(error + ": " + message)
        {
            this.error = error;
        }

        public ApiException() { }
        public ApiException(string message) : base(message) { }
        public ApiException(string message, Exception inner) : base(message, inner) { }
        protected ApiException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

}

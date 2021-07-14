using System;
using System.Runtime.Serialization;

namespace my_books_api.Data.Services
{
    [Serializable]
    private class PublisherNameException : Exception
    {
        private string v;
        private string name;

        public PublisherNameException()
        {
        }

        public PublisherNameException(string message) : base(message)
        {
        }

        public PublisherNameException(string v, string name)
        {
            this.v = v;
            this.name = name;
        }

        public PublisherNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PublisherNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
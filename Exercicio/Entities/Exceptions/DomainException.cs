using System;

namespace Exercicio.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base("Withdrow error: " + message) { }
    }
}

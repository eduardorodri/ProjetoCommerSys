using System;

namespace ProjetoInterdisciplinar.Services.Exceptions {
    public class DbConcurrencyException : ApplicationException {
        public DbConcurrencyException(string message) : base(message) {
        }
    }
}

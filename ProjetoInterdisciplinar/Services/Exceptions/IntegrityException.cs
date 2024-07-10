using System;

namespace ProjetoInterdisciplinar.Services.Exceptions {
    public class IntegrityException : ApplicationException {
        public IntegrityException(string message) : base(message) {
        }
    }
}

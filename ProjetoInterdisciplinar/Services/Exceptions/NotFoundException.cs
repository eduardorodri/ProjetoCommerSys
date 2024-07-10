using System;

namespace ProjetoInterdisciplinar.Services.Exceptions {
    public class NotFoundException : ApplicationException {
        public NotFoundException(string message) : base(message) {
               
        }
    }
}

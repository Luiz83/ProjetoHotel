namespace ProjetoHotel.Lib.Exceptions
{
    public class ValidationErrorException : Exception
    {
        public ValidationErrorException()
        {

        }

        public ValidationErrorException(string message) : base(message)
        {

        }
    }
}
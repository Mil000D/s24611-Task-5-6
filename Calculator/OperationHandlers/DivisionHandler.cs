using Calculator.Enum;
using Calculator.OperationRequest;

namespace Calculator.OperationHandlers
{
    public class DivisionHandler : IOperationHandler
    {
        private IOperationHandler? _nextHandler;

        public IOperationHandler SetNextHandler(IOperationHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Calculate(Request request)
        {
            if (request.Operation == Operation.Divide)
            {
                if (request.Number2 != 0)
                {
                    Console.WriteLine($"{request.Number1} / {request.Number2} = {request.Number1 / request.Number2}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Calculate(request);
            }
        }
    }
}

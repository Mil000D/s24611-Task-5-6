using Calculator.Enum;
using Calculator.OperationRequest;

namespace Calculator.OperationHandlers
{
    public class SubtractionHandler : IOperationHandler
    {
        private IOperationHandler? _nextHandler;

        public IOperationHandler SetNextHandler(IOperationHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Calculate(Request request)
        {
            if (request.Operation == Operation.Subtract)
            {
                Console.WriteLine($"{request.Number1} - {request.Number2} = {request.Number1 - request.Number2}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Calculate(request);
            }
        }
    }
}

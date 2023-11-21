using Calculator.Enum;
using Calculator.OperationRequest;

namespace Calculator.OperationHandlers
{
    public class ExponentiationHandler : IOperationHandler
    {
        public IOperationHandler SetNextHandler(IOperationHandler handler)
        {
            return this;
        }

        public void Calculate(Request request)
        {
            if (request.Operation == Operation.Exponent)
            {
                Console.WriteLine($"{request.Number1} ^ {request.Number2} = {Math.Pow(request.Number1, request.Number2)}");
            }
            else
            {
                Console.WriteLine("Operation not supported");
            }
        }
    }
}

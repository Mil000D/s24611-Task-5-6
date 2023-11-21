using Calculator.OperationRequest;

namespace Calculator.OperationHandlers
{
    public interface IOperationHandler
    {
        public IOperationHandler SetNextHandler(IOperationHandler handler);
        public void Calculate(Request request);
    }
}

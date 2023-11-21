using Calculator.Enum;
using Calculator.OperationHandlers;
using Calculator.OperationRequest;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AdditionHandler additionHandler = new AdditionHandler();
            SubtractionHandler subtractionHandler = new SubtractionHandler();
            MultiplicationHandler multiplicationHandler = new MultiplicationHandler();
            DivisionHandler divisionHandler = new DivisionHandler();
            ExponentiationHandler exponentiationHandler = new ExponentiationHandler();

            additionHandler.SetNextHandler(subtractionHandler)
                           .SetNextHandler(multiplicationHandler)
                           .SetNextHandler(divisionHandler)
                           .SetNextHandler(exponentiationHandler);

            Request additionRequest = new Request { Operation = Operation.Add, Number1 = 30, Number2 = 25 };
            Request subtractionRequest = new Request { Operation = Operation.Subtract, Number1 = 20, Number2 = 35 };
            Request multiplicationRequest = new Request { Operation = Operation.Multiply, Number1 = 30, Number2 = 45 };
            Request divisionRequest1 = new Request { Operation = Operation.Divide, Number1 = 20, Number2 = 10 };
            Request divisionRequest2 = new Request { Operation = Operation.Divide, Number1 = 40, Number2 = 0 };
            Request exponentiationRequest = new Request { Operation = Operation.Exponent, Number1 = 2, Number2 = 5 };

            additionHandler.Calculate(additionRequest);
            additionHandler.Calculate(subtractionRequest);
            additionHandler.Calculate(multiplicationRequest);
            additionHandler.Calculate(divisionRequest1);
            additionHandler.Calculate(divisionRequest2);
            additionHandler.Calculate(exponentiationRequest);
            additionHandler.Calculate(new Request { Operation = Operation.Add, Number1 = 10, Number2 = 5 });
        }
    }
}

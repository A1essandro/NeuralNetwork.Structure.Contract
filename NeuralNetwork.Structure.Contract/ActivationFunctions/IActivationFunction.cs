namespace NeuralNetwork.Structure.Contract.ActivationFunctions
{
    public interface IActivationFunction
    {

        double GetEquation(double x);

        double GetDerivative(double x);

    }
}

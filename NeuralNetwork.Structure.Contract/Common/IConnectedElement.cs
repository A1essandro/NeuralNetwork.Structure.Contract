namespace NeuralNetwork.Structure.Contract.Common
{

    public interface IConnectedElement<in T>
    {

        void ConnectTo(T connectionElement);

        void DisconnectFrom(T connectionElement);

    }

}

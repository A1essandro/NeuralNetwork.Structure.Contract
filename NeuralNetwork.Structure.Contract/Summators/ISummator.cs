using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Synapses;

namespace NeuralNetwork.Structure.Contract.Summators
{
    public interface ISummator : IConnectedElement<ISynapse>, INumberConductor<ISummator>
    {

    }
}
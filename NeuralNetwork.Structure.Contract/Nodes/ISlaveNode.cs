using NeuralNetwork.Structure.Contract.ActivationFunctions;
using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Summators;
using NeuralNetwork.Structure.Contract.Synapses;

namespace NeuralNetwork.Structure.Contract.Nodes
{

    /// <summary>
    /// Node that has synapses
    /// </summary>
    public interface ISlaveNode : INotInputNode, IConnectedElement<ISynapse>
    {

        /// <summary>
        /// Activation function
        /// </summary>
        /// <value></value>
        IActivationFunction Function { get; set; }

        /// <summary>
        /// Summator
        /// </summary>
        /// <value></value>
        ISummator Summator { get; set; }

    }

}

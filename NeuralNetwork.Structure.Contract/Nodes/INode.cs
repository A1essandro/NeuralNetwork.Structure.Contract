using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Layers;
using System;

namespace NeuralNetwork.Structure.Contract.Nodes
{

    /// <summary>
    /// Interface for neurons in network
    /// </summary>
    public interface INode : INumberConductor<INode>, IChildStructure<IReadOnlyLayer<INode>>, IDisposable
    {

    }

}
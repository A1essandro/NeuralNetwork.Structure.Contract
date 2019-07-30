using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Networks;
using NeuralNetwork.Structure.Contract.Nodes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeuralNetwork.Structure.Contract.Layers
{

    public interface IReadOnlyLayer<out TNode> : IChildStructure<ISimpleNetwork>, IDisposable
        where TNode : INode
    {

        IEnumerable<TNode> Nodes { get; }

        int NodesQuantity { get; }

        event Func<IReadOnlyLayer<TNode>, IEnumerable<double>, Task> OnNetworkInput;

    }

}
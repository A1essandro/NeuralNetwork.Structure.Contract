using NeuralNetwork.Structure.Contract.Nodes;

namespace NeuralNetwork.Structure.Contract.Layers
{
    public interface ILayer<TNode> : IReadOnlyLayer<TNode>
        where TNode : INode
    {

        void AddNode(TNode node);

        bool RemoveNode(TNode node);

    }
}
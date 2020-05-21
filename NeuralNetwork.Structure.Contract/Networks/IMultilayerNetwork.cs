using NeuralNetwork.Structure.Contract.Layers;
using NeuralNetwork.Structure.Contract.Nodes;
using System.Collections.Generic;

namespace NeuralNetwork.Structure.Contract.Networks
{
    public interface IMultilayerNetwork : ISimpleNetwork
    {

        IReadOnlyList<ILayer<INotInputNode>> InnerLayers { get; }

        IMultilayerNetwork AddInnerLayer(ILayer<INotInputNode> layer);

        IMultilayerNetwork RemoveInnerLayer(ILayer<INotInputNode> layer);

    }
}

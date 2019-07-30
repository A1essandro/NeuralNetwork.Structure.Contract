using System.Collections.Generic;
using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Nodes;

namespace NeuralNetwork.Structure.Contract.Layers
{

    /// <summary>
    /// Input layer of network
    /// </summary>
    public interface IInputLayer : ILayer<IMasterNode>, IInput<IEnumerable<double>>
    {
    }

}

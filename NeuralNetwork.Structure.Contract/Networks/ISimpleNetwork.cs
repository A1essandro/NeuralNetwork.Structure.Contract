using NeuralNetwork.Structure.Contract.Common;
using NeuralNetwork.Structure.Contract.Layers;
using NeuralNetwork.Structure.Contract.Nodes;
using NeuralNetwork.Structure.Contract.Synapses;
using System;
using System.Collections.Generic;

namespace NeuralNetwork.Structure.Contract.Networks
{

    public interface ISimpleNetwork : IInput<IEnumerable<double>>, IOutput<IEnumerable<double>>, IDataConductor<ISimpleNetwork, IEnumerable<double>>, IDisposable
    {

        /// <summary>
        /// All layers from input to output
        /// </summary>
        IEnumerable<ILayer<INode>> Layers { get; }

        /// <summary>
        /// Layer for input data. First layer of the network
        /// </summary>
        ILayer<IMasterNode> InputLayer { get; set; }

        /// <summary>
        /// Layer for output data. Last layer of the network
        /// </summary>
        ILayer<INotInputNode> OutputLayer { get; set; }

        /// <summary>
        /// Collection of synapses in the network
        /// </summary>
        ICollection<ISynapse> Synapses { get; }

        /// <summary>
        /// Add and connect synapse
        /// </summary>
        /// <param name="synapse"></param>
        ISimpleNetwork AddSynapse(ISynapse synapse);

    }

}

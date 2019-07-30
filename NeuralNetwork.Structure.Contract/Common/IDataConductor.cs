using System;
using System.Threading.Tasks;

namespace NeuralNetwork.Structure.Contract.Common
{
    public interface IDataConductor<out TThis, out TData>
        where TThis : IDataConductor<TThis, TData>
    {

        event Func<TThis, TData, Task> OnResultCalculated;

        TData LastCalculatedValue { get; }

    }
}

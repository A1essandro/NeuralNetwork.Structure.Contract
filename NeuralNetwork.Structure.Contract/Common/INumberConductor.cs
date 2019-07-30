namespace NeuralNetwork.Structure.Contract.Common
{
    public interface INumberConductor<out TThis> : IDataConductor<TThis, double>
        where TThis : IDataConductor<TThis, double>
    {

    }
}

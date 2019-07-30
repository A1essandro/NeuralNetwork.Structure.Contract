namespace NeuralNetwork.Structure.Contract.Common
{

    public interface IChildStructure<in TParentStructure>
    {

        void InsertInto(TParentStructure parentStructure);

        void RemoveFrom(TParentStructure parentStructure);

    }

}

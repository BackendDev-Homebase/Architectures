namespace Layered2.BusinesLogic
{
    internal interface IBusinessLogicLayer
    {
        internal Task<string> Greet(string name);
    }
}

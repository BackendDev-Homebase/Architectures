namespace Layered2.BusinesLogic
{
    internal interface IBusinessLogicLayer
    {
        internal Task<string> GetGreetingMessage(string name);
    }
}

namespace Layered2.DataAcess
{
    internal interface IDataAccessLayer
    {
        internal Task StoreUserCounts(Dictionary<string, int> userCounts);

        internal Task<Dictionary<string, int>> LoadUserCounts();
    }
}

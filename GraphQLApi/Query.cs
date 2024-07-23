namespace GraphQLApi;

public class Query
{
    public List<int> GetNumbers()
    {
        return [1, 2, 3, 4];
    }
    public int GetNumbersByValue(int value)
    {
        return new List<int>([1, 2, 3, 4]).FirstOrDefault(x => x == value);
    }
}
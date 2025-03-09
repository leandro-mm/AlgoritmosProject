using System.Security.Cryptography.X509Certificates;

namespace AlgoritmosProject.Services.LRU;

public class LRU_CacheService
{
    private readonly int _capacity;
    private readonly LinkedList<KeyValuePair<int,int>> _stackCache = [];

    public LRU_CacheService(int capacity)=>_capacity = capacity;

    public int Get(int key)
    {
        KeyValuePair<int, int>? node = _stackCache.First(t=>t.Key ==key);

        if (node is KeyValuePair<int, int>  && node is KeyValuePair<int, int> {Key: > 0, Value: >0 })
        {
            return node.Value.Value; 
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (_stackCache.Count == 0)
        {
            _stackCache.AddLast(new KeyValuePair<int, int>(key, value));
        }
        else
        {
            KeyValuePair<int, int>? nodeWithMaxKey = _stackCache.MaxBy(x => x.Key);
            int nodeKey = nodeWithMaxKey.Value.Key + 1;

            if (_stackCache.Count == _capacity)
            {
                KeyValuePair<int, int> nodeWithMinValue = _stackCache.MaxBy(x => x.Key);

                _stackCache.Remove(nodeWithMinValue);
            }

            KeyValuePair<int, int> newNode = new(nodeKey, value);

            _stackCache.AddLast(newNode);
        }
    }

    public IEnumerator<KeyValuePair<int, int>> GetEnumerator()
    {
        return _stackCache.GetEnumerator();
    }
}

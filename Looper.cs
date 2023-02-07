using BenchmarkDotNet.Attributes;

namespace ForeachOrFor;

[MemoryDiagnoser]
public class Looper
{
    private readonly List<int> _list;

    public Looper()
    {
        _list = new List<int>();
        for (var i = 0; i < 500; i++)
        {
            _list.Add(i);
        }
    }

    [Benchmark]
    public void LoopingForeach()
    {
        foreach (var item in _list)
        {
            //do nothing
        }
    }

    [Benchmark]
    public void LoopingFor()
    {
        for (var i = 0; i < _list.Count; i++)
        {
//do nothing            
        }
    }
}
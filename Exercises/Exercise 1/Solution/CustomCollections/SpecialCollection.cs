using System.Collections;

namespace CustomCollections;

public class SpecialCollection<T> : ICollection<T>
{
    private readonly int _initialSize;
    private T[] _items;

    #region Constructors
    public SpecialCollection() : this(10) { }
    public SpecialCollection(int initalSize)
    {
        _initialSize = initalSize;
        _items = new T[_initialSize];
    }
    #endregion
    #region Operators
    public T? this[int idx]
    {
        get
        {
            if (idx >= 0 && idx < Count)
            {
                return _items[idx];
            }
            return default;
        }
        set
        {
            if (value != null && idx >= 0 && idx < _items.Length)
            {
                _items[idx] = value;
            }
        }
    }
    public static implicit operator SpecialCollection<T>(T[] array)
    {
        var collection = new SpecialCollection<T>(array.Length);
        for (var i = 0; i < array.Length; i++)
        {
            collection.Add(array[i]);
        }
        return collection;
    }
    #endregion
    #region ICollection
    public int Count => _items.Where(it => it != null).Count();
    public bool IsReadOnly => false;
    public void Add(T? item)
    {
        if (item == null) return;
        var index = 0;
        for (; index < _items.Length; index++)
        {
            if (_items[index] == null)
            {
                _items[index] = item;
                return;
            }
        }
        Array.Resize<T>(ref _items, _items.Length * 2);
        _items[index] = item;
    }
    public void Clear()
    {
        Array.Clear(_items);
        Array.Resize(ref _items, _initialSize);
    }
    public bool Contains(T item)
    {
        return _items.Contains(item);
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
        var j = 0;
        for (var i = arrayIndex; i < _items.Length; i++)
        {
            array[i] = _items[j++];
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return _items.AsEnumerable<T>().GetEnumerator();
    }
    public bool Remove(T? item)
    {
        if (item == null) return false;
        var idx = Array.IndexOf(_items, item);
        if (idx >= 0)
        {
            var before = new ArraySegment<T>(_items, 0, idx);
            var after = new ArraySegment<T>(_items, idx + 1, Count - idx - 1);
            _items = before.Concat(after).ToArray();
            return true;
        }
        return false;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _items.GetEnumerator();
    }
    #endregion
}

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public class ElementCollection<K, T> : ElementCollection<T>, ICollection, ICollection<T>, IList<T>, INotifyCollectionChanged, IEquatable<ElementCollection<T>>
  where T : IUniqueModelElement<K> where K : notnull
{

  public ElementCollection() : base() { }

  public ElementCollection(IEnumerable<T> other) : base(other)
  {
    foreach (var item in other)
      Add(item);
  }

  #region IDictionary implementation
  private Dictionary<K, int> Index { get; set; } = new();


  public new void Add(T item)
  {
    var key = item.GetKey();
    if (ContainsKey(key))
      throw new InvalidOperationException($"{item.GetType()} with the same key {key} already exists");
    base.Add(item);
    Index.Add(key, Count-1);
  }

  public new void Clear()
  {
    Index.Clear();
    base.Clear();
  }

  public bool ContainsKey(K key)
  {
    return Index.ContainsKey(key);
  }

  public new bool Contains(T item)
  {
    var key = item.GetKey();
    return Index.ContainsKey(key);
  }

  public new bool Remove(T item)
  {
    var key = item.GetKey();
    var ok = Index.TryGetValue(key, out var index);
    if (ok)
    {
      ok = Index.Remove(key);
      base.RemoveAt(index);
    }
    return ok;
  }

  public bool TryGetValue(K key, [MaybeNullWhen(false)] out T value)
  {
    var ok = Index.TryGetValue(key, out var index);
    if (ok)
      value = base[index];
    else
      value = default(T);
    return ok;
  }

  public T? this[K key]
  {
    get
    {
      var ok = Index.TryGetValue(key, out var index);
      if (ok)
        return base[index];
      else
        return default(T);
    }
    set
    {
      var ok = Index.TryGetValue(key, out var index);
      if (value != null)
      {
        if (ok)
          base[index] = value;
        else
          Add(value);
      }
      else
      {
        if (ok)
          base.RemoveAt(index);
      }
    }
  }

  #endregion

  #region IEquatable implementation

  public override bool Equals(ModelElement? obj) => Equals(obj as ElementCollection<K,T>);

  public override bool Equals(ElementCollection<T>? other)
  {
    if (other is null) 
      return false;
    var thisEnumerator = other.GetEnumerator();
    var otherEnumerator = other.GetEnumerator();
    while (thisEnumerator.MoveNext() && otherEnumerator.MoveNext())
    {
      var thisItem = thisEnumerator.Current;
      var otherItem = otherEnumerator.Current;
      if (thisItem is ModelElement && otherItem is ModelElement)
        if (!thisItem.Equals(otherItem)) 
          return false;
        else
        if (!EqualityComparer<T>.Default.Equals(thisItem, otherItem)) 
          return false;
    }
    if (this.Count != other.Count) 
      return false;
    return true;
  }

  public override int GetHashCode()
  {
    var thisHashCode = 0; //EqualityComparer<Type>.Default.GetHashCode(this.GetType());
    foreach (var item in this)
    {
      if (item!=null)
        //thisHashCode = HashCode.Combine(thisHashCode, EqualityComparer<T>.Default.GetHashCode(item));
        thisHashCode = HashCode.Combine(thisHashCode, item.GetHashCode());
    }
    return thisHashCode;
  }
  #endregion
}

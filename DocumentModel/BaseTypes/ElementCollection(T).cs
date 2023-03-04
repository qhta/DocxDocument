namespace DocumentModel;
public class ElementCollection<T> : ModelElement, ICollection, ICollection<T>, INotifyCollectionChanged, IEquatable<ElementCollection<T>>
  //where T: ModelElement
{

  public ElementCollection(){ }

  public ElementCollection(ElementCollection<T> other)
  { 
    foreach (var item in other)
      Add(item);
  }

  #region ICollection implementation
  private ObservableCollection<T> Items = new();

  public void Add(T item)
  {
    ((ICollection<T>)Items).Add(item);
  }

  public void Clear()
  {
    ((ICollection<T>)Items).Clear();
  }

  public bool Contains(T item)
  {
    return ((ICollection<T>)Items).Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    ((ICollection<T>)Items).CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    return ((ICollection<T>)Items).Remove(item);
  }

  [XmlIgnore]
  [JsonIgnore]
  public int Count => ((ICollection<T>)Items).Count;

  [XmlIgnore]
  [JsonIgnore]
  public bool IsReadOnly => ((ICollection<T>)Items).IsReadOnly;

  public IEnumerator<T> GetEnumerator()
  {
    return ((IEnumerable<T>)Items).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }

  #endregion

  #region INotifyCollectionChangedEvent implementation

  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add
    {
      ((INotifyCollectionChanged)Items).CollectionChanged += value;
    }

    remove
    {
      ((INotifyCollectionChanged)Items).CollectionChanged -= value;
    }
  }
  #endregion

  #region IEquatable implementation
  //protected virtual Type EqualityContract => typeof(ElementCollection<T>);

  public override bool Equals(ModelElement? obj) => Equals(obj as ElementCollection<T>);

  public virtual bool Equals(ElementCollection<T>? other)
  {
    if (other is null /*|| EqualityContract != other.EqualityContract*/) return false;
    var thisEnumerator = other.GetEnumerator();
    var otherEnumerator = other.GetEnumerator();
    while (thisEnumerator.MoveNext() && otherEnumerator.MoveNext())
    {
      var thisItem = thisEnumerator.Current;
      var otherItem = otherEnumerator.Current;
      if (thisItem is ModelElement && otherItem is ModelElement)
        if (!thisItem.Equals(otherItem)) return false;
      else
        if (!EqualityComparer<T>.Default.Equals(thisItem, otherItem)) return false;
    }
    if (this.Count != other.Count) return false;
    return true;
  }

  void ICollection.CopyTo(Array array, int index)
  {
    throw new NotImplementedException();
  }

  bool ICollection.IsSynchronized { get; }
  object ICollection.SyncRoot { get; } = new object();

  //public override int GetHashCode()
  //{
  //  var thisHashCode = EqualityComparer<Type>.Default.GetHashCode(EqualityContract);
  //  foreach (var item in this)
  //  {
  //    if (item!=null)
  //      thisHashCode = HashCode.Combine(thisHashCode, EqualityComparer<T>.Default.GetHashCode(item));
  //  }
  //  return thisHashCode;
  //}

  //protected virtual bool PrintMembers(StringBuilder builder)
  //{
  //  foreach (var item in this)
  //    if (item!=null)
  //      builder.AppendLine(item.ToString());
  //  return true;
  //}

  #endregion
}

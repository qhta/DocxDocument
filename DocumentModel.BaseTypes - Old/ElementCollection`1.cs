namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public class ElementCollection<T> : ModelElement, ICollection, ICollection<T>, IList<T>, INotifyCollectionChanged
//where T : IModelElement
{

  public ElementCollection() { }

  public ElementCollection(IEnumerable<T> other)
  {
    foreach (var item in other)
      Add(item);
  }

  protected override void SetParent(ModelElement? parent)
  {
    base.SetParent(parent);
    foreach (var item in this)
      if (item is IModelElement iModelElement)
        iModelElement.Parent = parent;
  }

  #region ICollection implementation
  private List<T> Items = new();

  public void Add(T item)
  {
    Items.Add(item);
    if (item is IModelElement iModelElement)
      iModelElement.Parent = Parent ?? this;
    OnCollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
  }

  public void Clear()
  {
    Items.Clear();
    OnCollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
  }

  public bool Contains(T item)
  {
    return Items.Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    Items.CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    var index = Items.IndexOf(item);
    if (index < 0)
      return false;
    var ok = Items.Remove(item);
    if (ok)
      OnCollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, null, item, index));
    return ok;
  }

  public int Count => Items.Count;

  public bool IsReadOnly => false;

  public IEnumerator<T> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  #endregion

  #region IList implementation
  void ICollection.CopyTo(Array array, int index)
  {
    throw new NotImplementedException();
  }

  bool ICollection.IsSynchronized { get; }

  object ICollection.SyncRoot { get; } = new object();

  public int IndexOf(T item)
  {
    return Items.IndexOf(item);
  }

  public void Insert(int index, T item)
  {
    Items.Insert(index, item);
    if (item is IModelElement iModelElement)
      iModelElement.Parent = Parent ?? this;
    OnCollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, null, index));
  }

  public void RemoveAt(int index)
  {
    var item = Items[index];
    Items.RemoveAt(index);
    OnCollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, null, item, index));
  }

  public T this[int index] { get => Items[index]; set => Items[index] = value; }
  #endregion

  #region INotifyCollectionChangedEvent implementation

  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add
    {
      OnCollectionChanged += value;
    }

    remove
    {
      OnCollectionChanged -= value;
    }
  }

  protected NotifyCollectionChangedEventHandler? OnCollectionChanged;
  #endregion

}

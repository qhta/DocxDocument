namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public class ElementCollection<T> : ModelElement, ICollection, ICollection<T>, IList<T>, INotifyCollectionChanged, IEquatable<ElementCollection<T>>
  where T : IModelElement
{

  public ElementCollection() { }

  public ElementCollection(ElementCollection<T> other)
  {
    foreach (var item in other)
      Add(item);
  }

  protected override void SetParent(ModelElement? parent)
  {
    base.SetParent(parent);
    foreach (var item in this)
      item.Parent = parent;
  }

  public bool ReloadFrom(IEnumerable<DX.OpenXmlElement>? elements,
    CreateModelElementMethod createElementMethod)
  {
    if (elements != null)
    {
      foreach (var element in elements)
      {
        var item = createElementMethod(element);
        if (item is T modelElement)
          Add(modelElement);
        else if (item!=null)
          throw new InvalidOperationException($"Type {item.GetType()} does not implement {typeof(T)}");
      }
    }
    return true;
  }
  #region ICollection implementation
  private List<T> Items = new();

  public void Add(T item)
  {
    Items.Add(item);
    item.Parent = Parent ?? this;
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

  [XmlIgnore]
  [JsonIgnore]
  public int Count => Items.Count;

  [XmlIgnore]
  [JsonIgnore]
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
    item.Parent = Parent ?? this;
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

/// <summary>
/// Used in collection object conversion methods to pass a specific method to create a model element from an openXml element.
/// </summary>
/// <param name="openXmlElement">OpenXml element read from DocumentFormat.OpenXml document.</param>
/// <returns>Newly created model element (or <c>null</c> if openXmlElement is not recognized)</returns>
public delegate DM.IModelElement? CreateModelElementMethod(DX.OpenXmlElement openXmlElement);
namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public abstract class ElementCollection<ItemType> : ObservableCollection<ItemType>, 
  IElementCollection<ItemType>//, IEquatable<ElementCollection<ItemType>>
  where ItemType: ICollectionItem
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  protected ElementCollection()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="items"></param>
  protected ElementCollection(IEnumerable<ItemType> items) : base(items)
  {
  }

  /// <summary>
  /// Gets the first item in the collection, or null if the collection is empty.
  /// </summary>
  public ItemType? First => this.Count > 0 ? this[0] : default;

  /// <summary>
  /// Gets the last item in the collection, or null if the collection is empty.
  /// </summary>

  public ItemType? Last => this.Count > 0 ? this[this.Count - 1] : default;

  /// <summary>
  /// Raises the PropertyChanged event for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically from within a
  /// property's setter. This is commonly used to support data binding in UI frameworks.</remarks>
  /// <param name="propertyName">The name of the property that changed. Cannot be null or empty.</param>
  public void NotifyPropertyChanged(string propertyName)
  {
    OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
  }

//  /// <summary>
//  /// Compares this collection to another collection for equality.
//  /// </summary>
//  /// <param name="other">The other collection to compare to.</param>
//  /// <returns>true if the collections are equal; otherwise, false.</returns>
//  public bool Equals(ElementCollection<ItemType>? other)
//  {
//    if (this.Count != other?.Count) return false;
//    for (int i = 0; i < this.Count; i++)
//    {
//      if (!this[i].Equals(other[i])) return false;
//    }
//    return true;
//  }

//  /// <summary>
//  /// Compares this collection to another object for equality.
//  /// </summary>
//  /// <param name="obj">The object to compare to.</param>
//  /// <returns>true if the objects are equal; otherwise, false.</returns>
//#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
//  public override bool Equals(object? obj)
//  {
//    if (obj is null) return false;
//    if (ReferenceEquals(this, obj)) return true;
//    if (obj.GetType() != GetType()) return false;
//    return Equals((ElementCollection<ItemType>)obj);
//  }

}

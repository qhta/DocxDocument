using System.Collections.Specialized;

namespace DocumentModel;

/// <summary>
/// Represents a dynamic collection of values that supports change notification and provides collection semantics
/// similar to a list.
/// </summary>
/// <remarks>ValueCollection(T)provides observable collection behavior, raising collection change notifications
/// when items are added, removed, or the collection is refreshed. It implements both generic and non-generic collection
/// interfaces, allowing use in a variety of collection scenarios. The collection is not thread-safe; external
/// synchronization is required for concurrent access from multiple threads.</remarks>
/// <typeparam name="T">The type of elements contained in the collection.</typeparam>
public class ValueCollection<T> : ObservableCollection<T>, IEquatable<ValueCollection<T>>
  where T: IEquatable<T>
{

  /// <summary>
  /// Initializes a new instance of the ValueCollection class.
  /// </summary>
  public ValueCollection(){ }

  /// <summary>
  /// Initializes a new instance of the ValueCollection class that contains the elements copied from the specified
  /// collection.
  /// </summary>
  /// <param name="other">The ValueCollection whose elements are copied to the new collection. Cannot be null.</param>
  public ValueCollection(ValueCollection<T> other)
  { 
    foreach (var item in other)
      Add(item);
  }


  #region IEquatable implementation

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public virtual bool Equals(ValueCollection<T>? other)
 {
    if (other is null /*|| EqualityContract != other.EqualityContract*/) return false;
    using var thisEnumerator = GetEnumerator();
    using var otherEnumerator = other.GetEnumerator();
    while (thisEnumerator.MoveNext() && otherEnumerator.MoveNext())
    {
      var thisItem = thisEnumerator.Current;
      var otherItem = otherEnumerator.Current;
      if (!thisItem.Equals(otherItem)) return false;
    }
    if (this.Count != other.Count) return false;
    return true;
  }

  public override int GetHashCode()
  {
    var thisHashCode = 0;//EqualityComparer<Type>.Default.GetHashCode(EqualityContract);
    foreach (var item in this)
    {
      thisHashCode = HashCode.Combine(thisHashCode, EqualityComparer<T>.Default.GetHashCode(item));
    }
    return thisHashCode;
  }

  //protected virtual bool PrintMembers(StringBuilder builder)
  //{
  //  foreach (var item in this)
  //    if (item!=null)
  //      builder.AppendLine(item.ToString());
  //  return true;
  //}

  #endregion
}

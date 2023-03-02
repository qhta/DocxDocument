namespace DocumentModel;
public class ElementCollection<T> : Collection<T>, IEquatable<ElementCollection<T>>, IEquatable<object>
{
  public ElementCollection(){ }

  public ElementCollection(ElementCollection<T> other)
  { 
    foreach (var item in other)
      Add(item);
  }

  protected virtual Type EqualityContract => typeof(ElementCollection<T>);

  public override bool Equals(object? obj) => Equals(obj as ElementCollection<T>);

  public virtual bool Equals(ElementCollection<T>? other)
  {
    if (other is null || EqualityContract != other.EqualityContract) return false;
    if (this.Count != other.Count) return false;
    var enumerator = other.GetEnumerator();
    foreach (var thisItem in this)
    {
      enumerator.MoveNext();
      var otherItem = enumerator.Current;
      if (!EqualityComparer<T>.Default.Equals(thisItem, otherItem)) return false;
    }
    return true;
  }

  public override int GetHashCode()
  {
    var thisHashCode = EqualityComparer<Type>.Default.GetHashCode(EqualityContract);
    foreach (var item in this)
    {
      if (item!=null)
        thisHashCode = HashCode.Combine(thisHashCode, EqualityComparer<T>.Default.GetHashCode(item));
    }
    return thisHashCode;
  }

  protected virtual bool PrintMembers(StringBuilder builder)
  {
    foreach (var item in this)
      if (item!=null)
        builder.AppendLine(item.ToString());
    return true;
  }
}

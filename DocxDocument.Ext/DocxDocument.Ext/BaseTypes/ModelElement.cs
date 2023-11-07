namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement : IEquatable<ModelElement>, ICloneable, IModelElement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  [XmlIgnore]
  [NonComparable]
  public ModelElement? Parent
  {
    get => _Parent;
    set => SetParent(value);
  }

  protected virtual void SetParent(ModelElement? parent)
    => _Parent = parent;

  protected ModelElement? _Parent;

  [XmlIgnore]
  [NonComparable]
  public virtual Document? ParentDocument
  {
    get
    {
      if (Parent is Document document)
        return document;
      if (Parent != null)
        return Parent.ParentDocument;
      return null;
    }
  }

  public virtual bool Equals(ModelElement? other)
  {
    if (other == null) return false;
    if (other.GetType().IsEqualOrSubclassOf(this.GetType()))
      return Int32.Equals(this.GetHashCode(), other.GetHashCode());
    return false;
  }

  public override int GetHashCode()
  {
    var hashCode = 0;
    foreach (var prop in this.GetType().GetProperties())
    {
      if (prop.GetCustomAttribute<NonComparableAttribute>() != null)
        continue;
      var value = prop.GetValue(this);
      if (value != null)
      {
        int val = 0;
        if (prop.PropertyType.IsGenericTypeDefinition && value is IEnumerable enumerable)
        {
          val = 0;
          foreach (var item in enumerable)
            val = HashCode.Combine(val, item.GetHashCode());
        }
        else
          val = value.GetHashCode();
        hashCode = HashCode.Combine(hashCode, val);
      }
    }
    return hashCode;
  }

  public bool Compare(ModelElement? other) => ModelObjectComparer.CompareObjects(this, other);

  public object Clone()
  {
    var constructor = this.GetType().GetConstructor(new Type[]{ });
    if (constructor==null)
      throw new InvalidOperationException($"Type {this.GetType()} must have a parameterless constructor to clone");
    var newInstance = constructor.Invoke(new object[]{ });
    var props = this.GetType().GetProperties()
      .Where(item => item.GetCustomAttribute<DataMemberAttribute>() != null && item.CanWrite).ToArray();
    foreach (var prop in props)
    {
      var value = prop.GetValue(this);
      if (value is not null)
        prop.SetValue(newInstance, value);
    }
    return newInstance;
  }
}
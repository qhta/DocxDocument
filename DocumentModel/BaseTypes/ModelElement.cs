using DeepEqual.Syntax;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement : IEquatable<ModelElement>, IModelElement
{

  [XmlIgnore]
  [NonComparable]
  public virtual ModelElement? Parent { get => _Parent; set => _Parent = value; }
  protected ModelElement? _Parent;

  //[XmlAttribute("Parent")]
  //public string? ParentName { get => Parent?.GetType().Name; set { } }

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
      if (value!=null)
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
}
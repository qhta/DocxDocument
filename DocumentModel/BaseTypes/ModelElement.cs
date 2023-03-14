using DeepEqual.Syntax;

namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement: IEquatable<ModelElement>, IModelElement
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
      return other.IsDeepEqual(this);
    return false;
  }

}
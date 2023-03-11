using DeepEqual.Syntax;

namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement: IEquatable<ModelElement>
{

  [XmlIgnore] public ModelElement? Parent { get; set; }

  public virtual bool Equals(ModelElement? other)
  {
    if (other == null) return false;
    if (other.GetType().IsEqualOrSubclassOf(this.GetType()))
      return other.IsDeepEqual(this);
    return false;
  }

}
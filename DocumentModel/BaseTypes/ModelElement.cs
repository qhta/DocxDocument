using DeepEqual.Syntax;

namespace DocumentModel;

public class ModelElement: IEquatable<ModelElement>
{
  public virtual bool Equals(ModelElement? other)
  {
    if (other == null) return false;
    if (other.GetType().IsEqualOrSubclassOf(this.GetType()))
      return other.IsDeepEqual(this);
    return false;
  }

}
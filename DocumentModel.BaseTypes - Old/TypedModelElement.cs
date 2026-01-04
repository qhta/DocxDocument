namespace DocumentModel;

/// <summary>
/// Base class for all model elements recognized by its type. 
/// </summary>
public class TypedModelElement : ModelElement, IUniqueModelElement<Type>
{
  /// <summary>
  /// Type of model element used as a key in elements collection.
  /// </summary>
  /// <returns></returns>
  public Type GetKey() => this.GetType();
}
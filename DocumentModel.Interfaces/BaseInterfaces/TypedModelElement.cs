namespace DocumentModel;
/// <summary>
/// Base interface for all model elements recognized by its type. 
/// </summary>
public interface TypedModelElement : UniqueModelElement<Type>
{
  /// <summary>
  /// Gets the element type.
  /// </summary>
  /// <returns></returns>
  public Type GetElementType();
}
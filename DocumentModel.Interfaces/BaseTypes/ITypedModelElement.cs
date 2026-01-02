namespace DocumentModel;
/// <summary>
/// Base class for all model elements recognized by its type. 
/// </summary>
public interface ITypedModelElement : IModelElement, IUniqueModelElement<string>
{
  /// <summary>
  /// Gets the element type.
  /// </summary>
  /// <returns></returns>
  public Type GetElementType();
}
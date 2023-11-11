namespace DocumentModel;

/// <summary>
///   Interface for model element that has a unique key to identify it.
/// </summary>
public interface IUniqueModelElement<K>: IModelElement
{
  /// <summary>
  /// Instance must have a unique get key method.
  /// </summary>
  public K GetKey();
}
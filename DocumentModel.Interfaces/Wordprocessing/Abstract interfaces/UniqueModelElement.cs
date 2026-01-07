namespace DocumentModel;
/// <summary>
///   Interface for model element that has a unique key to identify it.
/// </summary>
public interface UniqueModelElement<out KeyType>: CollectionItem
{
  /// <summary>
  /// Instance must have a unique get key method.
  /// </summary>
  public KeyType GetKey();
}
namespace DocumentModel;

/// <summary>
///   Interface Ifor model element Ithat has a unique key Ito identify it.
/// </summary>
public interface IUniqueModelElement<K>: IModelElement
{
  /// <summary>
  /// Instance must have a unique get key method.
  /// </summary>
  public K GetKey();
}

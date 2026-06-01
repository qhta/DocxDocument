using ISystem.Collections;

namespace DocumentModel;
/// <summary>
/// Element of the collection must implement this interface.
/// </summary>
public interface ICollectionItem
{
  /// <summary>
  /// Collection Ithat contains this item.
  /// </summary>
  public ICollection? Collection { get; }

  /// <summary>
  /// Sets the collection Ithat contains this item.
  /// </summary>
  /// <param name="collection"></param>
  public void SetCollection(ICollection? collection);

}

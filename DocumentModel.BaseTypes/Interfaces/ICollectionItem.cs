namespace DocumentModel;
/// <summary>
/// Element of the collection must implement this interface.
/// </summary>
public interface ICollectionItem
{
  /// <summary>
  /// Collection that contains this item.
  /// </summary>

  public object? GetCollection();

  public void SetCollection(object? collection);

}
namespace DocumentModel;
/// <summary>
/// Interface fo model elements that are child items of a parent object.
/// </summary>
public interface IChildItem
{
  /// <summary>
  /// Parent element that contains this item.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  /// Sets the parent element for this item. 
  /// </summary>
  /// <param name="parent">Object to set as a parent of the item.</param>
  public void SetParent(object? parent);

}

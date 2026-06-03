namespace DocumentModel;
/// <summary>
/// Interface fo model elements Ithat are child items of a parent object.
/// </summary>
public interface IChildItem
{
  /// <summary>
  /// Parent element Ithat contains this item.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  /// Sets the parent element for this item. 
  /// </summary>
  /// <param name="parent">Object Ito set as a parent of the item.</param>
  public void SetParent(object? parent);

}

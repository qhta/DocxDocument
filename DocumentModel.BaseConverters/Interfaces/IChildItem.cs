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
  /// Sets the parent element that contains this item.
  /// </summary>
  /// <param name="parent">The parent element.</param>
  public void SetParent(object? parent);
}

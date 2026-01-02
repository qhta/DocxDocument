namespace DocumentModel;

/// <summary>
/// Defines a contract for specifying the size of child controls within a menu.
/// </summary>
public interface IItemSizeControl
{
  /// <summary>
  ///   Specifies the size of the child controls in this menu.
  ///
  ///  If this attribute is omitted, the menu's child controls SHOULD default to the normal size.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }
}
namespace DocumentModel;

/// <summary>
/// Defines the contract for a control that displays a collection of selectable items, supporting dynamic item
/// population and customization through callback functions.
/// </summary>
/// <remarks>Implementations of this interface allow for flexible item management, including dynamic generation of
/// item labels, images, screentips, and other properties via named callback functions. This enables integration with
/// data sources or logic that determine the available items and their presentation at runtime. The interface is
/// intended for use in UI frameworks or components that require customizable item selection controls.</remarks>
public interface IItemControl
{
  /// <summary>
  ///   Specifies whether this control displays icons on its selection items.
  ///
  ///  If this attribute is omitted, the items' icons SHOULD be shown by default.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the number of selection items in this control.
  /// 
  ///   If this attribute is omitted, the control SHOULD display any selection items that are specified as child elements.
  ///   If no such items are specified, the control SHOULD be empty.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the label of a specific dynamically-created selection item, identified by index.
  /// 
  ///   If this attribute is omitted, dynamically-created selection items SHOULD NOT display labels.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the screentip of a specific dynamically-created selection item, identified by index.
  /// 
  ///   If this attribute is omitted, dynamically-created selection items SHOULD use their labels as their screentips, or display no screentips at all.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the supertip of a specific dynamically-created selection item, identified by index.
  /// 
  ///   If this attribute is omitted, dynamically-created selection items SHOULD NOT display supertips.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the icon of a specific dynamically-created selection item, identified by index.
  /// 
  ///   If this attribute is omitted, dynamically-created selection items SHOULD NOT display icons.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the identifier of a specific dynamically-created selection item, identified by index.
  /// 
  ///   If this attribute is omitted, dynamically-created selection items SHOULD have empty identifiers.
  /// </summary>
  public string? GetItemID { get; set; }
}
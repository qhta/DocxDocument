namespace DocumentModel;

/// <summary>
/// Defines members for a control that supports selection of an item, allowing configuration of callbacks to determine
/// the selected item's identifier or index.
/// </summary>
/// <remarks>Implementations use either the GetSelectedItemID or GetSelectedItemIndex property to specify how the
/// selected item is determined. These properties are mutually exclusive; only one should be set at a time. If neither
/// property is set, the control does not display a selected item.</remarks>
public interface ISelectedItemControl
{
  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the identifier of the item that is selected in this control.
  ///
  ///   The GetSelectedItemID and GetSelectedItemIndex attributes are mutually exclusive.If neither attribute is specified, the control SHOULD NOT display a selected item.
  /// </summary>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the index of the item to be selected in this control.
  ///
  ///   The GetSelectedItemID and GetSelectedItemIndex attributes are mutually exclusive.If neither attribute is specified, the control SHOULD NOT display a selected item.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }
}
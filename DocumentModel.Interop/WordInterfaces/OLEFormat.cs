namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the OLE characteristics (other than linking) for an OLE object, ActiveX control, or field.
/// </summary>
public partial interface OLEFormat : InteropObject
{
  /// <summary>
  /// The class type.
  /// </summary>
  public string ClassType { get; set; }

  /// <summary>
  /// The display as icon.
  /// </summary>
  public bool DisplayAsIcon { get; set; }

  /// <summary>
  /// The icon name.
  /// </summary>
  public string IconName { get; set; }

  /// <summary>
  /// The icon path.
  /// </summary>
  public string IconPath { get; }

  /// <summary>
  /// The icon index.
  /// </summary>
  public int IconIndex { get; set; }

  /// <summary>
  /// The icon label.
  /// </summary>
  public string IconLabel { get; set; }

  /// <summary>
  /// The label.
  /// </summary>
  public string Label { get; }

  /// <summary>
  /// The object.
  /// </summary>
  public object Object { get; }

  /// <summary>
  /// The prog id.
  /// </summary>
  public string ProgID { get; }

  /// <summary>
  /// The preserve formatting on update.
  /// </summary>
  public bool PreserveFormattingOnUpdate { get; set; }
}

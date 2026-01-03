namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public interface WebExtensionTaskpane: IModelElement
{
  /// <summary>
  ///   dockstate
  /// </summary>
  public string? DockState { get; set; }
  /// <summary>
  ///   visibility
  /// </summary>
  public bool? Visibility { get; set; }
  /// <summary>
  ///   width
  /// </summary>
  public Double? Width { get; set; }
  /// <summary>
  ///   row
  /// </summary>
  public UInt32? Row { get; set; }
  /// <summary>
  ///   locked
  /// </summary>
  public bool? Locked { get; set; }
  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  public WebExtensionPartReference? WebExtensionPartReference { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
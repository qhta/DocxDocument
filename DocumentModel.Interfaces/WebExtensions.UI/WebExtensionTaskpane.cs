namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionTaskPane Class.
/// </summary>
public interface WebExtensionTaskPane: CollectionItem
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
namespace DocumentModel.WebExtensions.UI;
/// <summary>
///   Defines the WebExtensionTaskPane Class.
/// </summary>
[DataContract]
[XmlRoot("WebExtensionTaskPane", Namespace = "DocumentModel.WebExtensions.UI")]
public class WebExtensionTaskPane : ModelElement
{
  /// <summary>
  ///   dockstate
  /// </summary>
  public string? DockState { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   visibility
  /// </summary>
  public bool? Visibility { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   width
  /// </summary>
  public Double? Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   row
  /// </summary>
  public UInt32? Row { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   locked
  /// </summary>
  public bool? Locked { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  public WebExtensionPartReference? WebExtensionPartReference { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
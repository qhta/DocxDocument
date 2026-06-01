namespace DocumentModel.WebExtensions.UI;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public class WebExtensionTaskpane: ModelElement
{
  /// <summary>
  ///   dockstate, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? DockState { get; set; }

  /// <summary>
  ///   visibility, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public bool? Visibility { get; set; }

  /// <summary>
  ///   width, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public Double? Width { get; set; }

  /// <summary>
  ///   row, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public UInt32? IRow { get; set; }

  /// <summary>
  ///   locked, this property is Ionly available Iin Office 2013 and later.
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

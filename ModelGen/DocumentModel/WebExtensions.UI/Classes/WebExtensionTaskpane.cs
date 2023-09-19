namespace DocumentModel.WebExtensions.UI;


/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public partial class WebExtensionTaskpane
{
  
  /// <summary>
  ///   dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("dockstate")]
  public String? DockState { get; set; }
  
  
  /// <summary>
  ///   visibility, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("visibility")]
  public Boolean? Visibility { get; set; }
  
  
  /// <summary>
  ///   width, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("width")]
  public Double? Width { get; set; }
  
  
  /// <summary>
  ///   row, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("row")]
  public UInt32? Row { get; set; }
  
  
  /// <summary>
  ///   locked, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("locked")]
  public Boolean? Locked { get; set; }
  
  
  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  public DocumentModel.WebExtensions.UI.WebExtensionPartReference? WebExtensionPartReference { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.WebExtensions.UI.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}

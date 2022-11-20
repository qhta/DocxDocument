namespace DocumentModel.Office2013.WebExtentionPane;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtentionPane.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtentionPane.IWebExtensionPartReference))]
public class WebExtensionTaskpane: IWebExtensionTaskpane
{
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  public string? DockState
  {
    get;
    set;
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Visibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  public double? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Row
  {
    get;
    set;
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  public IWebExtensionPartReference? WebExtensionPartReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.WebExtentionPane.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}

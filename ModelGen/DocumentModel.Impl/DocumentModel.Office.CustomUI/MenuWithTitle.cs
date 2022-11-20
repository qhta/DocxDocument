namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the MenuWithTitle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedGallery))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IMenuSeparator))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IMenuWithTitle))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ISplitButtonWithTitle))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedToggleButton))]
public class MenuWithTitle: IMenuWithTitle
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public string? IdQ
  {
    get;
    set;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public string? Tag
  {
    get;
    set;
  }
  
  /// <summary>
  /// itemSize
  /// </summary>
  public DocumentModel.Office.CustomUI.ItemSizeValues? ItemSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// title
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// getTitle
  /// </summary>
  public string? GetTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// image
  /// </summary>
  public string? Image
  {
    get;
    set;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public string? ImageMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  public string? GetImage
  {
    get;
    set;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public string? Screentip
  {
    get;
    set;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public string? GetScreentip
  {
    get;
    set;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public string? Supertip
  {
    get;
    set;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public string? GetSupertip
  {
    get;
    set;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public bool? Enabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public string? GetEnabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// label
  /// </summary>
  public string? Label
  {
    get;
    set;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public string? GetLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public string? InsertAfterMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public string? InsertAfterQ
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ
  {
    get;
    set;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public bool? Visible
  {
    get;
    set;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public string? GetVisible
  {
    get;
    set;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public string? Keytip
  {
    get;
    set;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public string? GetKeytip
  {
    get;
    set;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public bool? ShowLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public string? GetShowLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  public bool? ShowImage
  {
    get;
    set;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public string? GetShowImage
  {
    get;
    set;
  }
  
}

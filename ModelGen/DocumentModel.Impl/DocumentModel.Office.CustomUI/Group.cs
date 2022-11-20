namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the Group Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IButtonGroup))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IComboBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDialogBoxLauncher))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDropDown))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IEditBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IGallery))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ITextLabel))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IVerticalSeparator))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ISplitButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IToggleButton))]
public class Group: IGroup
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
  
}

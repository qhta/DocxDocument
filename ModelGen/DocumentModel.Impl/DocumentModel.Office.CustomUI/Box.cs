namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the Box Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IButtonGroup))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IComboBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDropDown))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IEditBox))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IGallery))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ITextLabel))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ISplitButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IToggleButton))]
public class Box: IBox
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
  /// boxStyle
  /// </summary>
  public DocumentModel.Office.CustomUI.BoxStyleValues? BoxStyle
  {
    get;
    set;
  }
  
}

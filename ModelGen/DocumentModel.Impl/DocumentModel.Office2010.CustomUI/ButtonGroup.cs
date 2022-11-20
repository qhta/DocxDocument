namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButtonRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IControlCloneRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDynamicMenuRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IGalleryRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IMenuRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISeparator))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISplitButtonRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IToggleButtonRegular))]
public class ButtonGroup: IButtonGroup
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId
  {
    get;
    set;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag
  {
    get;
    set;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible
  {
    get;
    set;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId
  {
    get;
    set;
  }
  
}

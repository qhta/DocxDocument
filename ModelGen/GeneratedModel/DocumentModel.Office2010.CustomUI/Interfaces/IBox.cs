namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the Box Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButtonGroup))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IComboBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDropDownRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IEditBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IGallery))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ILabelControl))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IMenu))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISplitButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IToggleButton))]
public interface IBox // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get ; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get ; set; }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get ; set; }
  
  /// <summary>
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.CustomUI.BoxStyle? BoxStyle { get ; set; }
  
}

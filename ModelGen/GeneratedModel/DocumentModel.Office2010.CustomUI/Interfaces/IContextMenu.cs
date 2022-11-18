namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButtonRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IControlCloneRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDynamicMenuRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IGalleryRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IMenuRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IMenuSeparatorNoTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISplitButtonRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IToggleButtonRegular))]
public interface IContextMenu // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get ; set; }
  
}

namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the GroupBox Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageCheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageComboBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageDropDown))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageEditBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageGroupButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageLabelControl))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IGroupBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IHyperlink))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IImageControl))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ILayoutContainer))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IRadioGroup))]
public interface IGroupBox // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public Expand? Expand { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
}

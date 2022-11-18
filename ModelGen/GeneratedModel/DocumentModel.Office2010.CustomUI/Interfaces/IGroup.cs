namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the Group Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButtonGroup))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IComboBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDialogBoxLauncher))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDropDownRegular))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IEditBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IGallery))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ILabelControl))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IMenu))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISeparator))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISplitButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IToggleButton))]
public interface IGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get ; set; }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get ; set; }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetImage { get ; set; }
  
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
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get ; set; }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get ; set; }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get ; set; }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get ; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get ; set; }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get ; set; }
  
  /// <summary>
  /// autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? AutoScale { get ; set; }
  
  /// <summary>
  /// centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? CenterVertically { get ; set; }
  
}

namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the BackstageMenuGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageMenuButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageMenuCheckBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageMenuToggleButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageSubMenu))]
public interface IBackstageMenuGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.CustomUI.ItemSize? ItemSize { get ; set; }
  
}

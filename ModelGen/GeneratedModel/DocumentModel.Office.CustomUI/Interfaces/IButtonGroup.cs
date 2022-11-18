namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedDynamicMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedGallery))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedSplitButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedToggleButton))]
public interface IButtonGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public string? IdQ { get ; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get ; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get ; set; }
  
}

namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IExtensionListModify))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.INonVisualContentPartProperties))]
public interface IContentPart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteModeValues? BwMode { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// ExtensionListModify.
  /// </summary>
  public IExtensionListModify? ExtensionListModify { get ; set; }
  
}

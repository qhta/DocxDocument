namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the GvmlContentPart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.INonVisualContentPartProperties))]
public interface IGvmlContentPart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelationshipId { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}

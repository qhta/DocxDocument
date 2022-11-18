namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.IApplicationNonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualContentPartProperties))]
public interface IContentPart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelationshipId { get ; set; }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}

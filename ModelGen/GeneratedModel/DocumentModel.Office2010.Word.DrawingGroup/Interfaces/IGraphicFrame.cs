namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the GraphicFrame Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.INonVisualGraphicFrameProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.ITransform2D))]
public interface IGraphicFrame // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGraphicFrameProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}

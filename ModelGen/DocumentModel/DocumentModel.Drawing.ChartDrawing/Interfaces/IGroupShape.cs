namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.IContentPart))]
public interface IGroupShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}

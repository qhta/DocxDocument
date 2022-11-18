namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.ITransform))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualGraphicFrameProperties))]
public interface IGraphicFrame // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public string? Macro { get ; set; }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public bool? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
}

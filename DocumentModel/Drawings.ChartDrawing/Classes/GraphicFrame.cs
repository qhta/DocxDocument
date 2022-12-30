namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public partial class GraphicFrame
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public Boolean? Published { get; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Transform? Transform { get; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get; set; }
  
}

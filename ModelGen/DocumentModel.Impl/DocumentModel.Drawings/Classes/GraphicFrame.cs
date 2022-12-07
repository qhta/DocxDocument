namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Frame.
/// </summary>
public class GraphicFrameImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>, GraphicFrame
{
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public Transform? Transform
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public Graphic? Graphic
  {
    get;
    set;
  }
  
}

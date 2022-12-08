namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Frame.
/// </summary>
public class GraphicFrameImpl: ModelElementImpl, GraphicFrame
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public Boolean? Published
  {
    get;
    set;
  }
  
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

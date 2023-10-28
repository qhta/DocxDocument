namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Graphic Frame.
/// </summary>
public partial class GraphicFrame
{
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }
  
  
  /// <summary>
  ///   Publish To Server
  /// </summary>
  public Boolean? Published { get; set; }
  
  
  /// <summary>
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  public DMDCD.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
  
  
  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  public DMDCD.Transform? Transform { get; set; }
  
  
  /// <summary>
  ///   Graphical Object.
  /// </summary>
  public DMD.Graphic? Graphic { get; set; }
  
}

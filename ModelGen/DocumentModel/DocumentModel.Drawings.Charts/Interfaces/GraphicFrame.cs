namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface GraphicFrame
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public DocumentModel.Drawings.Charts.Transform? Transform { get ; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get ; set; }
  
}

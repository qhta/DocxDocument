namespace DocumentModel.Drawings;

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
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public Transform? Transform { get ; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public Graphic? Graphic { get ; set; }
  
}

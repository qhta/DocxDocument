namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public interface NonVisualGraphicFrameProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}

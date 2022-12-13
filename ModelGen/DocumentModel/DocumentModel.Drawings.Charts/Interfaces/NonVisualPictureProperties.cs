namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public interface NonVisualPictureProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}

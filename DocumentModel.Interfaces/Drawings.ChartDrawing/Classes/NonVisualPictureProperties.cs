namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public interface NonVisualPictureProperties:
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  /// <summary>
  ///   Non-Visual Picture Drawing Properties.
  /// </summary>
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get; set; }
}
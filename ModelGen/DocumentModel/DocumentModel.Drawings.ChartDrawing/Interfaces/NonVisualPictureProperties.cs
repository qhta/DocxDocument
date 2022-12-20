namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public partial interface NonVisualPictureProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get; set; }
  
}

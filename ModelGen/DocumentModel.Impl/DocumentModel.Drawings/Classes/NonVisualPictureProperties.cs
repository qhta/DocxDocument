namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public class NonVisualPicturePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>, NonVisualPictureProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties2? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get;
    set;
  }
  
}

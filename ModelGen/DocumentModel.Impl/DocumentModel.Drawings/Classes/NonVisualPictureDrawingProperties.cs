namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public class NonVisualPictureDrawingPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties>, NonVisualPictureDrawingProperties
{
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public PictureLocks? PictureLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get;
    set;
  }
  
}

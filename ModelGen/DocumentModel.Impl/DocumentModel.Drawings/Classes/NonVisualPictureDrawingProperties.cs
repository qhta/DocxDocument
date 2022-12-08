namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public class NonVisualPictureDrawingPropertiesImpl: ModelElementImpl, NonVisualPictureDrawingProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize
  {
    get;
    set;
  }
  
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

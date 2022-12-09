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
    get => (Boolean?)OpenXmlElement?.PreferRelativeResize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PreferRelativeResize = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public PictureLocks? PictureLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

namespace DocumentModel.Drawings.Charts;

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
  
  public NonVisualPictureDrawingPropertiesImpl(): base() {}
  
  public NonVisualPictureDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize
  {
    get => (System.Boolean?)OpenXmlElement?.PreferRelativeResize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PreferRelativeResize = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public DocumentModel.Drawings.PictureLocks? PictureLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public class ImageLayerImpl: ModelElementImpl, ImageLayer
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Embed
  {
    get => (String?)OpenXmlElement?.Embed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Embed = (System.String?)value;
    }
  }
  
  public Collection<ImageEffect>? ImageEffects
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

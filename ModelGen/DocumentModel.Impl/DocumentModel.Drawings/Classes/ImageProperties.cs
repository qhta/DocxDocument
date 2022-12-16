namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public class ImagePropertiesImpl: ModelElementImpl, ImageProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ImagePropertiesImpl(): base() {}
  
  public ImagePropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public DocumentModel.Drawings.ImageLayer? ImageLayer
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
        if (item != null)
          return new DocumentModel.Drawings.ImageLayerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ImageLayerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

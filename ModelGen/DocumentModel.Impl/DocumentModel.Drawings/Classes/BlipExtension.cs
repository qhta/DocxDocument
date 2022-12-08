namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public class BlipExtensionImpl: ModelElementImpl, BlipExtension
{
  public DocumentFormat.OpenXml.Drawing.BlipExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BlipExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public ImageProperties? ImageProperties
  {
    get;
    set;
  }
  
  public Boolean? UseLocalDpi
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.Drawings.WebVideoProperty? WebVideoProperty
  {
    get;
    set;
  }
  
  public SVGBlip? SVGBlip
  {
    get;
    set;
  }
  
  public PictureAttributionSourceURL? PictureAttributionSourceURL
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.OEmbed? OEmbed
  {
    get;
    set;
  }
  
  public OEmbedShared? OEmbedShared
  {
    get;
    set;
  }
  
}

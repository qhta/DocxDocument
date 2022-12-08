namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public interface BlipExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ImageProperties? ImageProperties { get ; set; }
  
  public Boolean? UseLocalDpi { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WebVideoProperty? WebVideoProperty { get ; set; }
  
  public SVGBlip? SVGBlip { get ; set; }
  
  public PictureAttributionSourceURL? PictureAttributionSourceURL { get ; set; }
  
  public DocumentModel.Wordprocessing.OEmbed? OEmbed { get ; set; }
  
  public OEmbedShared? OEmbedShared { get ; set; }
  
}

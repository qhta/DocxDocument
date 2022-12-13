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
  
  public DocumentModel.Drawings.ImageProperties? ImageProperties { get ; set; }
  
  public Boolean? UseLocalDpi { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WebVideoProperty? WebVideoProperty { get ; set; }
  
  public DocumentModel.Drawings.SVGBlip? SVGBlip { get ; set; }
  
  public DocumentModel.Drawings.PictureAttributionSourceURL? PictureAttributionSourceURL { get ; set; }
  
  public DocumentModel.Wordprocessing.OEmbed? OEmbed { get ; set; }
  
  public DocumentModel.Drawings.OEmbedShared? OEmbedShared { get ; set; }
  
}

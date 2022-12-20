namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public partial interface BlipExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.ImageProperties? ImageProperties { get; set; }
  
  public Boolean? UseLocalDpi { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WebVideoProperty? WebVideoProperty { get; set; }
  
  public DocumentModel.Drawings.SVG.SVGBlip? SVGBlip { get; set; }
  
  public DocumentModel.Drawings.PictureAttributionSourceURL? PictureAttributionSourceURL { get; set; }
  
  public DocumentModel.Wordprocessing.OEmbed.OEmbed? OEmbed { get; set; }
  
  public DocumentModel.Drawings.Office.OEmbed.OEmbedShared? OEmbedShared { get; set; }
  
}

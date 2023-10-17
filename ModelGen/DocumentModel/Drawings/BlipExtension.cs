namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class BlipExtension
{
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.ImageProperties? ImageProperties { get; set; }
  
  public Boolean? UseLocalDpi { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WebVideoProperty? WebVideoProperty { get; set; }
  
  public DocumentModel.Drawings.SVG.SVGBlip? SVGBlip { get; set; }
  
  public DocumentModel.Drawings.PictureAttributionSourceURL? PictureAttributionSourceURL { get; set; }
  
  public DocumentModel.Wordprocessing.OEmbed.OEmbed? OEmbed { get; set; }
  
  public DocumentModel.Drawings.OEmbed.OEmbedShared? OEmbedShared { get; set; }
  
}

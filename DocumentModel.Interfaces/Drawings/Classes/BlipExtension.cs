using DocumentModel.Drawings.Office.OEmbed;
using DocumentModel.Drawings.SVG;
using DocumentModel.Drawings.Wordprocessing;
using DocumentModel.Wordprocessing.OEmbed;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BlipExtension interface.
/// </summary>
public interface BlipExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public ImageProperties? ImageProperties { get; set; }
  public bool? UseLocalDpi { get; set; }
  public WebVideoProperty? WebVideoProperty { get; set; }
  public SVGBlip? SVGBlip { get; set; }
  public PictureAttributionSourceURL? PictureAttributionSourceURL { get; set; }
  public OEmbed? OEmbed { get; set; }
  public OEmbedShared? OEmbedShared { get; set; }
}
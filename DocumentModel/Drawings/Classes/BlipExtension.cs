using DocumentModel.Drawings.Office.OEmbed;
using DocumentModel.Drawings.SVG;
using DocumentModel.Drawings.Wordprocessing;
using DocumentModel.Wordprocessing.OEmbed;

namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BlipExtension Class.
/// </summary>
public record BlipExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public ImageProperties? ImageProperties { get; set; }

  public Boolean? UseLocalDpi { get; set; }

  public WebVideoProperty? WebVideoProperty { get; set; }

  public SVGBlip? SVGBlip { get; set; }

  public PictureAttributionSourceURL? PictureAttributionSourceURL { get; set; }

  public OEmbed? OEmbed { get; set; }

  public OEmbedShared? OEmbedShared { get; set; }
}
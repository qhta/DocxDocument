using DocumentModel.Drawings.Office.OEmbed;
using DocumentModel.Drawings.SVG;
using DocumentModel.Drawings.Wordprocessing;
using DocumentModel.Office2013.Word.Drawing;
using DocumentModel.Wordprocessing.OEmbed;
namespace DocumentModel.Drawings;

/// <summary>
/// Represents an extension for a blip (binary large image or picture), providing additional properties and metadata for enhanced image handling.
/// </summary>
public interface BlipExtension
{
  /// <summary>
  /// Gets or sets the URI that identifies the extension or provides additional context.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  /// Gets or sets the image properties associated with the blip extension.
  /// </summary>
  public ImageProperties? ImageProperties { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether to use the local DPI (dots per inch) setting for image rendering.
  /// </summary>
  public bool? UseLocalDpi { get; set; }

  /// <summary>
  /// Gets or sets the web video property, which provides metadata for embedded web videos.
  /// </summary>
  public WebVideoProperty? WebVideoProperty { get; set; }

  /// <summary>
  /// Gets or sets the SVG blip, which contains SVG image data for the extension.
  /// </summary>
  public SVGBlip? SVGBlip { get; set; }

  /// <summary>
  /// Gets or sets the picture attribution source URL, which provides attribution information for the image.
  /// </summary>
  public PictureAttributionSourceURL? PictureAttributionSourceURL { get; set; }

  /// <summary>
  /// Gets or sets the OEmbed data, which provides embedded content information using the OEmbed standard.
  /// </summary>
  public OEmbed? OEmbed { get; set; }

  /// <summary>
  /// Gets or sets the shared OEmbed data, which provides shared embedded content information.
  /// </summary>
  public OEmbedShared? OEmbedShared { get; set; }
}
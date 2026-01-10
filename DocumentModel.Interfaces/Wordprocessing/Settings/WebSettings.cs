"""````````csharp
namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents web page settings for a Wordprocessing document.
/// This interface provides properties for framesets, div elements, encoding, browser optimization, VML reliance, PNG support, CSS usage, file organization, file naming, display settings, and target screen size, enabling advanced configuration and management of web publishing options.
/// </summary>
public interface WebSettings : DocumentProperties
{
  
  /// <summary>
  /// Frameset configuration for the web page.
  /// </summary>
  public Frameset? Frameset { get; set; }
  
  /// <summary>
  /// Collection of div elements for the web page.
  /// </summary>
  public DivElements? Divs { get; set; }
  
  /// <summary>
  /// Web page encoding, specifying the character encoding used for the web page.
  /// </summary>
  public string? WebPageEncoding { get; set; }
  
  /// <summary>
  /// Indicates whether the web page is optimized for browser display.
  /// </summary>
  public bool? OptimizeForBrowser { get; set; }
  
  /// <summary>
  /// Indicates whether VML (Vector Markup Language) is relied upon for web page rendering.
  /// </summary>
  public bool? RelyOnVML { get; set; }
  
  /// <summary>
  /// Indicates whether PNG images are allowed in the web page.
  /// </summary>
  public bool? AllowPNG { get; set; }
  
  /// <summary>
  /// Indicates whether CSS is not relied upon for web page formatting.
  /// </summary>
  public bool? DoNotRelyOnCSS { get; set; }
  
  /// <summary>
  /// Indicates whether the web page should not be saved as a single file.
  /// </summary>
  public bool? DoNotSaveAsSingleFile { get; set; }
  
  /// <summary>
  /// Indicates whether the web page should not be organized in a folder.
  /// </summary>
  public bool? DoNotOrganizeInFolder { get; set; }
  
  /// <summary>
  /// Indicates whether long file names should not be used for web page resources.
  /// </summary>
  public bool? DoNotUseLongFileNames { get; set; }
  
  /// <summary>
  /// Pixels per inch setting for the web page, specifying display resolution.
  /// </summary>
  public int? PixelsPerInch { get; set; }
  
  /// <summary>
  /// Target screen size for the web page, specifying the intended display dimensions.
  /// </summary>
  public TargetScreenSizeKind? TargetScreenSize { get; set; }
}
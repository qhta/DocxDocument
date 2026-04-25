namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents web page settings for a Wordprocessing document.
/// This class provides properties for framesets, div elements, encoding, browser optimization, VML reliance, PNG support, CSS usage, file organization, file naming, display settings, and target screen size, enabling advanced configuration and management of web publishing options.
/// </summary>
[OpenXmlType(typeof(DXW.WebSettings))]
[XmlRoot("WebSettings", Namespace = "DocumentModel.Wordprocessing")]
public partial class WebSettings : ModelElement<DXW.WebSettings>
{
  /// <summary>
  /// Frameset configuration for the web page.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.Frameset))]
  public Frameset? Frameset { get => _Frameset; set => UpdateField(ref _Frameset, value, nameof(Frameset)); }
  private Frameset? _Frameset;

  /// <summary>
  /// Collection of div elements for the web page.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.Divs))]
  public DivElements? Divs { get => _Divs; set => UpdateField(ref _Divs, value, nameof(Divs)); }
  private DivElements? _Divs;

  /// <summary>
  /// Web page encoding, specifying the character encoding used for the web page.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.WebPageEncoding))]
  public string? WebPageEncoding { get => _WebPageEncoding; set => UpdateField(ref _WebPageEncoding, value, nameof(WebPageEncoding)); }
  private string? _WebPageEncoding;

  /// <summary>
  /// Indicates whether the web page is optimized for browser display.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.OptimizeForBrowser))]
  public bool? OptimizeForBrowser { get => _OptimizeForBrowser; set => UpdateField(ref _OptimizeForBrowser, value, nameof(OptimizeForBrowser)); }
  private bool? _OptimizeForBrowser;

  /// <summary>
  /// Indicates whether VML (Vector Markup Language) is relied upon for web page rendering.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.RelyOnVML))]
  public bool? RelyOnVML { get => _RelyOnVML; set => UpdateField(ref _RelyOnVML, value, nameof(RelyOnVML)); }
  private bool? _RelyOnVML;

  /// <summary>
  /// Indicates whether PNG images are allowed in the web page.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.AllowPNG))]
  public bool? AllowPNG { get => _AllowPNG; set => UpdateField(ref _AllowPNG, value, nameof(AllowPNG)); }
  private bool? _AllowPNG;

  /// <summary>
  /// Indicates whether CSS is not relied upon for web page formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.DoNotRelyOnCSS))]
  public bool? DoNotRelyOnCSS { get => _DoNotRelyOnCSS; set => UpdateField(ref _DoNotRelyOnCSS, value, nameof(DoNotRelyOnCSS)); }
  private bool? _DoNotRelyOnCSS;

  /// <summary>
  /// Indicates whether the web page should not be saved as a single file.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.DoNotSaveAsSingleFile))]
  public bool? DoNotSaveAsSingleFile { get => _DoNotSaveAsSingleFile; set => UpdateField(ref _DoNotSaveAsSingleFile, value, nameof(DoNotSaveAsSingleFile)); }
  private bool? _DoNotSaveAsSingleFile;

  /// <summary>
  /// Indicates whether the web page should not be organized in a folder.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.DoNotOrganizeInFolder))]
  public bool? DoNotOrganizeInFolder { get => _DoNotOrganizeInFolder; set => UpdateField(ref _DoNotOrganizeInFolder, value, nameof(DoNotOrganizeInFolder)); }
  private bool? _DoNotOrganizeInFolder;

  /// <summary>
  /// Indicates whether long file names should not be used for web page resources.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.DoNotUseLongFileNames))]
  public bool? DoNotUseLongFileNames { get => _DoNotUseLongFileNames; set => UpdateField(ref _DoNotUseLongFileNames, value, nameof(DoNotUseLongFileNames)); }
  private bool? _DoNotUseLongFileNames;

  /// <summary>
  /// Pixels per inch setting for the web page, specifying display resolution.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.PixelsPerInch))]
  public int? PixelsPerInch { get => _PixelsPerInch; set => UpdateField(ref _PixelsPerInch, value, nameof(PixelsPerInch)); }
  private int? _PixelsPerInch;

  /// <summary>
  /// Target screen size for the web page, specifying the intended display dimensions.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WebSettings.TargetScreenSize))]
  public TargetScreenSize? TargetScreenSize { get => _TargetScreenSize; set => UpdateField(ref _TargetScreenSize, value, nameof(TargetScreenSize)); }
  private TargetScreenSize? _TargetScreenSize;
}
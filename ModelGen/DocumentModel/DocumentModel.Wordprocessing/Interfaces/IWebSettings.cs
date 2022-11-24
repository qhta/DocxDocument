namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public interface IWebSettings // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Frameset.
  /// </summary>
  public IFrameset? Frameset { get ; set; }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public IDivs? Divs { get ; set; }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  public IWebPageEncoding? WebPageEncoding { get ; set; }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public IOptimizeForBrowser? OptimizeForBrowser { get ; set; }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public IRelyOnVML? RelyOnVML { get ; set; }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public IAllowPNG? AllowPNG { get ; set; }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public IDoNotRelyOnCSS? DoNotRelyOnCSS { get ; set; }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public IDoNotSaveAsSingleFile? DoNotSaveAsSingleFile { get ; set; }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public IDoNotOrganizeInFolder? DoNotOrganizeInFolder { get ; set; }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public IDoNotUseLongFileNames? DoNotUseLongFileNames { get ; set; }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public IPixelsPerInch? PixelsPerInch { get ; set; }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues>? TargetScreenSize { get ; set; }
  
  /// <summary>
  /// Gets the WebSettingsPart associated with this element.
  /// </summary>
  public IWebSettingsPart? WebSettingsPart { get ; set; }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public interface IWebSettings // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Frameset.
  /// </summary>
  public DocumentModel.Wordprocessing.IFrameset? Frameset { get ; set; }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public DocumentModel.Wordprocessing.IDivs? Divs { get ; set; }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  public System.String? WebPageEncoding { get ; set; }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public System.Boolean? OptimizeForBrowser { get ; set; }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public System.Boolean? RelyOnVML { get ; set; }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public System.Boolean? AllowPNG { get ; set; }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public System.Boolean? DoNotRelyOnCSS { get ; set; }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public System.Boolean? DoNotSaveAsSingleFile { get ; set; }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public System.Boolean? DoNotOrganizeInFolder { get ; set; }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public System.Boolean? DoNotUseLongFileNames { get ; set; }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public System.Int32? PixelsPerInch { get ; set; }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public DocumentModel.Wordprocessing.TargetScreenSizeKind? TargetScreenSize { get ; set; }
  
}

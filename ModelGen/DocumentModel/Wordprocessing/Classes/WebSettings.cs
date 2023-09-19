namespace DocumentModel.Wordprocessing;


/// <summary>
///   Web Page Settings.
/// </summary>
public partial class WebSettings
{
  
  /// <summary>
  ///   Frameset.
  /// </summary>
  public DocumentModel.Wordprocessing.Frameset? Frameset { get; set; }
  
  
  /// <summary>
  ///   Divs.
  /// </summary>
  public DocumentModel.Wordprocessing.Divs? Divs { get; set; }
  
  
  /// <summary>
  ///   WebPageEncoding.
  /// </summary>
  public String? WebPageEncoding { get; set; }
  
  
  /// <summary>
  ///   OptimizeForBrowser.
  /// </summary>
  public Boolean? OptimizeForBrowser { get; set; }
  
  
  /// <summary>
  ///   RelyOnVML.
  /// </summary>
  public Boolean? RelyOnVML { get; set; }
  
  
  /// <summary>
  ///   AllowPNG.
  /// </summary>
  public Boolean? AllowPNG { get; set; }
  
  
  /// <summary>
  ///   DoNotRelyOnCSS.
  /// </summary>
  public Boolean? DoNotRelyOnCSS { get; set; }
  
  
  /// <summary>
  ///   DoNotSaveAsSingleFile.
  /// </summary>
  public Boolean? DoNotSaveAsSingleFile { get; set; }
  
  
  /// <summary>
  ///   DoNotOrganizeInFolder.
  /// </summary>
  public Boolean? DoNotOrganizeInFolder { get; set; }
  
  
  /// <summary>
  ///   DoNotUseLongFileNames.
  /// </summary>
  public Boolean? DoNotUseLongFileNames { get; set; }
  
  
  /// <summary>
  ///   PixelsPerInch.
  /// </summary>
  public Int32? PixelsPerInch { get; set; }
  
  
  /// <summary>
  ///   TargetScreenSize.
  /// </summary>
  public DocumentModel.Wordprocessing.TargetScreenSizeValues? TargetScreenSize { get; set; }
  
}

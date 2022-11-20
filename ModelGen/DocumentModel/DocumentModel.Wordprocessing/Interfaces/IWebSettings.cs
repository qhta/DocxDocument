namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPixelsPerInch))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDivs))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrameset))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOptimizeForBrowser))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRelyOnVML))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAllowPNG))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoNotRelyOnCSS))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoNotSaveAsSingleFile))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoNotOrganizeInFolder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoNotUseLongFileNames))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWebPageEncoding))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITargetScreenSize))]
public interface IWebSettings // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
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
  public DocumentModel.Wordprocessing.ITargetScreenSize? TargetScreenSize { get ; set; }
  
}

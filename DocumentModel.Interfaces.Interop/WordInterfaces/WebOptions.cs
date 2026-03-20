namespace DocumentModel.Interop;

/// <summary>
/// Contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
/// </summary>
public partial interface WebOptions : InteropObject
{
  /// <summary>
  /// The optimize for browser.
  /// </summary>
  public bool OptimizeForBrowser { get; set; }

  /// <summary>
  /// The browser level.
  /// </summary>
  public WdBrowserLevel BrowserLevel { get; set; }

  /// <summary>
  /// The rely on css.
  /// </summary>
  public bool RelyOnCSS { get; set; }

  /// <summary>
  /// The organize in folder.
  /// </summary>
  public bool OrganizeInFolder { get; set; }

  /// <summary>
  /// The use long file names.
  /// </summary>
  public bool UseLongFileNames { get; set; }

  /// <summary>
  /// The rely on vml.
  /// </summary>
  public bool RelyOnVML { get; set; }

  /// <summary>
  /// The allow png.
  /// </summary>
  public bool AllowPNG { get; set; }

  /// <summary>
  /// The screen size.
  /// </summary>
  //public Core.MsoScreenSize ScreenSize { get; set; }

  /// <summary>
  /// The pixels per inch.
  /// </summary>
  public int PixelsPerInch { get; set; }

  /// <summary>
  /// The encoding.
  /// </summary>
  //public Core.MsoEncoding Encoding { get; set; }

  /// <summary>
  /// The folder suffix.
  /// </summary>
  public string FolderSuffix { get; }

  /// <summary>
  /// The target browser.
  /// </summary>
  //public Core.MsoTargetBrowser TargetBrowser { get; set; }
}

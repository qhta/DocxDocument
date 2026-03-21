namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions?view=word-pia"/>
public partial interface WebOptions : InteropObject
{
  /// <summary>
  /// The optimize for browser.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.optimizeforbrowser?view=word-pia"/>
  public bool OptimizeForBrowser { get; set; }

  /// <summary>
  /// The browser level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.browserlevel?view=word-pia"/>
  public WdBrowserLevel BrowserLevel { get; set; }

  /// <summary>
  /// The rely on css.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }

  /// <summary>
  /// The organize in folder.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.organizeinfolder?view=word-pia"/>
  public bool OrganizeInFolder { get; set; }

  /// <summary>
  /// The use long file names.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.uselongfilenames?view=word-pia"/>
  public bool UseLongFileNames { get; set; }

  /// <summary>
  /// The rely on vml.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyonvml?view=word-pia"/>
  public bool RelyOnVML { get; set; }

  /// <summary>
  /// The allow png.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.allowpng?view=word-pia"/>
  public bool AllowPNG { get; set; }

  /// <summary>
  /// The screen size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.screensize?view=word-pia"/>
  public Core.MsoScreenSize ScreenSize { get; set; }

  /// <summary>
  /// The pixels per inch.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.pixelsperinch?view=word-pia"/>
  public int PixelsPerInch { get; set; }

  /// <summary>
  /// The encoding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.encoding?view=word-pia"/>
  public Core.MsoEncoding Encoding { get; set; }

  /// <summary>
  /// The folder suffix.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.foldersuffix?view=word-pia"/>
  public string FolderSuffix { get; }

  /// <summary>
  /// The target browser.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.targetbrowser?view=word-pia"/>
  public Core.MsoTargetBrowser TargetBrowser { get; set; }
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains global application-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions?view=word-pia"/>
public interface DefaultWebOptions : InteropObject
{
  /// <summary>
  /// The optimize for browser.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.optimizeforbrowser?view=word-pia"/>
  public bool OptimizeForBrowser { get; set; }
  /// <summary>
  /// The browser level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.browserlevel?view=word-pia"/>
  public WdBrowserLevel BrowserLevel { get; set; }
  /// <summary>
  /// The rely on css.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }
  /// <summary>
  /// The organize in folder.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.organizeinfolder?view=word-pia"/>
  public bool OrganizeInFolder { get; set; }
  /// <summary>
  /// The update links on save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.updatelinksonsave?view=word-pia"/>
  public bool UpdateLinksOnSave { get; set; }
  /// <summary>
  /// The use long file names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.uselongfilenames?view=word-pia"/>
  public bool UseLongFileNames { get; set; }
  /// <summary>
  /// The check if office is htmleditor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.checkifofficeishtmleditor?view=word-pia"/>
  public bool CheckIfOfficeIsHTMLEditor { get; set; }
  /// <summary>
  /// The check if word is default htmleditor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.checkifwordisdefaulthtmleditor?view=word-pia"/>
  public bool CheckIfWordIsDefaultHTMLEditor { get; set; }
  /// <summary>
  /// The rely on vml.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.relyonvml?view=word-pia"/>
  public bool RelyOnVML { get; set; }
  /// <summary>
  /// The allow png.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.allowpng?view=word-pia"/>
  public bool AllowPNG { get; set; }
  /// <summary>
  /// The screen size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.screensize?view=word-pia"/>
  public Core.MsoScreenSize ScreenSize { get; set; }
  /// <summary>
  /// The pixels per inch.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.pixelsperinch?view=word-pia"/>
  public int PixelsPerInch { get; set; }
  /// <summary>
  /// The encoding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.encoding?view=word-pia"/>
  public Core.MsoEncoding Encoding { get; set; }
  /// <summary>
  /// The always save in default encoding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.alwayssaveindefaultencoding?view=word-pia"/>
  public bool AlwaysSaveInDefaultEncoding { get; set; }
  /// <summary>
  /// The fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.fonts?view=word-pia"/>
  public Core.WebPageFonts Fonts { get; }
  /// <summary>
  /// The folder suffix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.foldersuffix?view=word-pia"/>
  public string FolderSuffix { get; }
  /// <summary>
  /// The target browser.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.targetbrowser?view=word-pia"/>
  public Core.MsoTargetBrowser TargetBrowser { get; set; }
  /// <summary>
  /// The save new web pages as web archives.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.savenewwebpagesaswebarchives?view=word-pia"/>
  public bool SaveNewWebPagesAsWebArchives { get; set; }

}

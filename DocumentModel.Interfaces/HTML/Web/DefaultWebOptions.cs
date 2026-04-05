namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains global application-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions?view=word-pia"/>
public interface IDefaultWebOptions : IModelObject
{
  /// <summary>
  /// Gets or sets a value indicating whether Word optimizes documents for the target browser when saving as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.optimizeforbrowser?view=word-pia"/>
  public bool OptimizeForBrowser { get; set; }
  /// <summary>
  /// Gets or sets the target browser level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.browserlevel?view=word-pia"/>
  public BrowserLevel BrowserLevel { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether formatting is saved by using cascading style sheets (CSS).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether supporting files are organized in a separate folder when saving as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.organizeinfolder?view=word-pia"/>
  public bool OrganizeInFolder { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether links are updated when the document is saved as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.updatelinksonsave?view=word-pia"/>
  public bool UpdateLinksOnSave { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether long file names are used when saving as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.uselongfilenames?view=word-pia"/>
  public bool UseLongFileNames { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether Word checks whether Microsoft Office is the default HTML editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.checkifofficeishtmleditor?view=word-pia"/>
  public bool CheckIfOfficeIsHTMLEditor { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether Word checks whether it is the default HTML editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.checkifwordisdefaulthtmleditor?view=word-pia"/>
  public bool CheckIfWordIsDefaultHTMLEditor { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether Vector Markup Language (VML) is used for drawing objects in web pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.relyonvml?view=word-pia"/>
  public bool RelyOnVML { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether PNG graphics are allowed when saving as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.allowpng?view=word-pia"/>
  public bool AllowPNG { get; set; }
  /// <summary>
  /// Gets or sets the target screen size for saved web pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.screensize?view=word-pia"/>
  public DMD.ScreenSize ScreenSize { get; set; }
  /// <summary>
  /// Gets or sets the target pixels-per-inch value for saved web pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.pixelsperinch?view=word-pia"/>
  public int PixelsPerInch { get; set; }
  /// <summary>
  /// Gets or sets the default encoding used when saving web pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.encoding?view=word-pia"/>
  public Encoding Encoding { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether web pages are always saved in the default encoding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.alwayssaveindefaultencoding?view=word-pia"/>
  public bool AlwaysSaveInDefaultEncoding { get; set; }
  /// <summary>
  /// Gets the web page font settings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.fonts?view=word-pia"/>
  public App.IWebPageFonts Fonts { get; }
  /// <summary>
  /// Gets the suffix used for the folder that contains supporting files for saved web pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.foldersuffix?view=word-pia"/>
  public string FolderSuffix { get; }
  /// <summary>
  /// Gets or sets the target browser used for web page compatibility.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.targetbrowser?view=word-pia"/>
  public HTML.TargetBrowser TargetBrowser { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether new web pages are saved as single-file web archives.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.defaultweboptions.savenewwebpagesaswebarchives?view=word-pia"/>
  public bool SaveNewWebPagesAsWebArchives { get; set; }

}

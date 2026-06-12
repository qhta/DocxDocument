namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web
/// page.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions?view=word-pia"/>
public partial interface IWebOptions : IModelObject
{
  /// <summary>
  /// True if Microsoft Word optimizes new Web pages created in Word for the Web browser specified by the
  /// BrowserLevel property (for the DefaultWebOptions object). True if Word optimizes the specified Web page for
  /// the Web browser specified by the BrowserLevel property (for the WebOptions object).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.optimizeforbrowser?view=word-pia"/>
  public bool OptimizeForBrowser { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a constant that represents the level of Web browser at which you want to target the specified
  /// Web page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.browserlevel?view=word-pia"/>
  public BrowserLevel BrowserLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if cascading style sheets (CSS) are used for font formatting when you view a saved document in a Web
  /// browser.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if all supporting files, such as background textures and graphics, are organized in a separate folder
  /// when you save the specified document as a Web page. False if supporting files are saved in the same folder as
  /// the Web page. The default value is True.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.organizeinfolder?view=word-pia"/>
  public bool OrganizeInFolder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if long file names are used when you save the document as a Web page. False if long file names are not
  /// used and the DOS file name format (8.3) is used. The default value is True.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.uselongfilenames?view=word-pia"/>
  public bool UseLongFileNames { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if image files are not generated from drawing objects when you save a document as a Web page. False if
  /// images are generated. The default value is False.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyonvml?view=word-pia"/>
  public bool RelyOnVML { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if PNG (Portable Network Graphics) is allowed as an image format when you save a document as a Web page.
  /// False if PNG is not allowed as an output format. The default value is False.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.allowpng?view=word-pia"/>
  public bool AllowPNG { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the ideal minimum screen size (width by height, in pixels) that you should use when viewing
  /// the saved document in a Web browser.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.screensize?view=word-pia"/>
  public DMD.ScreenSize ScreenSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the density (pixels per inch) of graphics images and table cells on a Web page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.pixelsperinch?view=word-pia"/>
  public int PixelsPerInch { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the folder suffix that Microsoft Word uses when you save a document as a Web page, use long file
  /// names, and choose to save supporting files in a separate folder (that is, if the UseLongFileNames and
  /// OrganizeInFolder properties are set to True).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.foldersuffix?view=word-pia"/>
  public string FolderSuffix { get; }

  /// <summary>
  /// Sets or returns a constant representing the target browser for documents viewed in a Web browser.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.targetbrowser?view=word-pia"/>
  public HTML.TargetBrowser TargetBrowser { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

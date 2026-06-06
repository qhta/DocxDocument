namespace DocumentModel.Interop.Word;	
/// <summary>
/// Contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web
/// page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions?view=word-pia"/>
public interface IWebOptions : IInteropObject
{
  /// <summary>
  /// True if Microsoft Word optimizes new Web pages created in Word for the Web browser specified by the
  /// BrowserLevel property (for the DefaultWebOptions object). True if Word optimizes the specified Web page for
  /// the Web browser specified by the BrowserLevel property (for the WebOptions object).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.optimizeforbrowser?view=word-pia"/>
  public bool OptimizeForBrowser { get; set; }	
  /// <summary>
  /// Returns or sets a constant that represents the level of Web browser at which you want to target the specified
  /// Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.browserlevel?view=word-pia"/>
  public BrowserLevel BrowserLevel { get; set; }	
  /// <summary>
  /// True if cascading style sheets (CSS) are used for font formatting when you view a saved document in a Web
  /// browser.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }	
  /// <summary>
  /// True if all supporting files, such as background textures and graphics, are organized in a separate folder
  /// when you save the specified document as a Web page. False if supporting files are saved in the same folder as
  /// the Web page. The default value is True.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.organizeinfolder?view=word-pia"/>
  public bool OrganizeInFolder { get; set; }	
  /// <summary>
  /// True if long file names are used when you save the document as a Web page. False if long file names are not
  /// used and the DOS file name format (8.3) is used. The default value is True.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.uselongfilenames?view=word-pia"/>
  public bool UseLongFileNames { get; set; }	
  /// <summary>
  /// True if image files are not generated from drawing objects when you save a document as a Web page. False if
  /// images are generated. The default value is False.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.relyonvml?view=word-pia"/>
  public bool RelyOnVML { get; set; }	
  /// <summary>
  /// True if PNG (Portable Network Graphics) is allowed as an image format when you save a document as a Web page.
  /// False if PNG is not allowed as an output format. The default value is False.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.allowpng?view=word-pia"/>
  public bool AllowPNG { get; set; }	
  /// <summary>
  /// Returns or sets the ideal minimum screen size (width by height, in pixels) that you should use when viewing
  /// the saved document in a Web browser.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.screensize?view=word-pia"/>
  public Core.ScreenSize ScreenSize { get; set; }	
  /// <summary>
  /// Returns or sets the density (pixels per inch) of graphics images and table cells on a Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.pixelsperinch?view=word-pia"/>
  public int PixelsPerInch { get; set; }	
  /// <summary>
  /// Returns or sets the document encoding (code page or character set) to be used by the Web browser when you view
  /// the saved document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.encoding?view=word-pia"/>
  public Core.Encoding Encoding { get; set; }	
  /// <summary>
  /// Returns the folder suffix that Microsoft Word uses when you save a document as a Web page, use long file
  /// names, and choose to save supporting files in a separate folder (that is, if the UseLongFileNames and
  /// OrganizeInFolder properties are set to True).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.foldersuffix?view=word-pia"/>
  public string FolderSuffix { get; }	
  /// <summary>
  /// Sets or returns a constant representing the target browser for documents viewed in a Web browser.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.targetbrowser?view=word-pia"/>
  public Core.TargetBrowser TargetBrowser { get; set; }	

  #region methods	
/// <summary>
  /// Sets the folder suffix for the specified document to the default suffix for the language support you have
  /// selected or installed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.usedefaultfoldersuffix?view=word-pia"/>
  public void UseDefaultFolderSuffix();	
  #endregion methods
}

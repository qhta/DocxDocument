namespace DocumentModel.Wordprocessing;
/// <summary>
///   Web Page Settings.
/// </summary>
public interface IWebSettings: IDocumentProperties
{
    /// <summary>
    ///   Frameset.
    /// </summary>
    public IFrameset? Frameset { get; set; }
    /// <summary>
    ///   Divs.
    /// </summary>
    public IDivElements? Divs { get; set; }
    /// <summary>
    ///   WebPageEncoding.
    /// </summary>
    public string? WebPageEncoding { get; set; }
    /// <summary>
    ///   OptimizeForBrowser.
    /// </summary>
    public bool? OptimizeForBrowser { get; set; }
    /// <summary>
    ///   RelyOnVML.
    /// </summary>
    public bool? RelyOnVML { get; set; }
    /// <summary>
    ///   AllowPNG.
    /// </summary>
    public bool? AllowPNG { get; set; }
    /// <summary>
    ///   DoNotRelyOnCSS.
    /// </summary>
    public bool? DoNotRelyOnCSS { get; set; }
    /// <summary>
    ///   DoNotSaveAsSingleFile.
    /// </summary>
    public bool? DoNotSaveAsSingleFile { get; set; }
    /// <summary>
    ///   DoNotOrganizeInFolder.
    /// </summary>
    public bool? DoNotOrganizeInFolder { get; set; }
    /// <summary>
    ///   DoNotUseLongFileNames.
    /// </summary>
    public bool? DoNotUseLongFileNames { get; set; }
    /// <summary>
    ///   PixelsPerInch.
    /// </summary>
    public int? PixelsPerInch { get; set; }
    /// <summary>
    ///   TargetScreenSize.
    /// </summary>
    public TargetScreenSizeKind? TargetScreenSize { get; set; }
}
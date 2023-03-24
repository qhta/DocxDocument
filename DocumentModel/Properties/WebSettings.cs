using DocumentModel.Wordprocessing;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Web Page Settings.
/// </summary>
public class WebSettings: KnownDocumentProperties
{
    /// <summary>
    ///   Frameset.
    /// </summary>
    public Frameset? Frameset { get; set; }

    /// <summary>
    ///   Divs.
    /// </summary>
    public Divs? Divs { get; set; }

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
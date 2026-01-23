using DocumentModel.Drawings.Office.OEmbed;
using DocumentModel.Drawings.SVG;
using DocumentModel.Wordprocessing.OEmbed;

namespace DocumentModel.Drawings;
/// <summary>
/// Represents an extension for a blip (binary large image or picture), providing additional properties and metadata for enhanced image handling.
/// </summary>
public partial class BlipExtension : ModelElement<DXD.Extension>, IExtension
{
    /// <summary>
    /// Gets or sets the image properties associated with the blip extension.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public ImageProperties? ImageProperties { get => _ImageProperties; set => UpdateField(ref _ImageProperties, value, nameof(ImageProperties)); }

    private ImageProperties? _ImageProperties;
    /// <summary>
    /// Gets or sets a value indicating whether to use the local DPI (dots per inch) setting for image rendering.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public bool? UseLocalDpi { get => _UseLocalDpi; set => UpdateField(ref _UseLocalDpi, value, nameof(UseLocalDpi)); }

    private bool? _UseLocalDpi;
    /// <summary>
    /// Gets or sets the web video property, which provides metadata for embedded web videos.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public WebVideoProperty? WebVideoProperty { get => _WebVideoProperty; set => UpdateField(ref _WebVideoProperty, value, nameof(WebVideoProperty)); }

    private WebVideoProperty? _WebVideoProperty;
    /// <summary>
    /// Gets or sets the SVG blip, which contains SVG image data for the extension.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public SVGBlip? SVGBlip { get => _SVGBlip; set => UpdateField(ref _SVGBlip, value, nameof(SVGBlip)); }

    private SVGBlip? _SVGBlip;
    /// <summary>
    /// Gets or sets the picture attribution source URL, which provides attribution information for the image.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public PictureAttributionSourceURL? PictureAttributionSourceURL { get => _PictureAttributionSourceURL; set => UpdateField(ref _PictureAttributionSourceURL, value, nameof(PictureAttributionSourceURL)); }

    private PictureAttributionSourceURL? _PictureAttributionSourceURL;
    /// <summary>
    /// Gets or sets the OEmbed data, which provides embedded content information using the OEmbed standard.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public OEmbed? OEmbed { get => _OEmbed; set => UpdateField(ref _OEmbed, value, nameof(OEmbed)); }

    private OEmbed? _OEmbed;
    /// <summary>
    /// Gets or sets the shared OEmbed data, which provides shared embedded content information.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public OEmbedShared? OEmbedShared { get => _OEmbedShared; set => UpdateField(ref _OEmbedShared, value, nameof(OEmbedShared)); }

    private OEmbedShared? _OEmbedShared;
    /// <summary>
    /// Uri string associated with the blip extension.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Extension.Uri))]
    /// <summary>
    /// Uri string associated with the blip extension.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Extension))]
    public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private string? _Uri;
}
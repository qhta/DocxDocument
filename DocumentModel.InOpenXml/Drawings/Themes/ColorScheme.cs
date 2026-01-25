using DocumentModel.Drawings.Colors;

namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorScheme))]
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
public partial class ColorScheme : ModelElement<DXD.ColorScheme>, IExtendableElement
{
    /// <summary>
    /// FontName.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
    /// <summary>
    /// FontName.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Dark 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Dark1Color))]
    /// <summary>
    /// Dark 1.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
#region specific color definitions
    public IDrawingColor? Dark1Color { get => _Dark1Color; set => UpdateField(ref _Dark1Color, value, nameof(Dark1Color)); }

    private IDrawingColor? _Dark1Color;
    /// <summary>
    /// Light 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Light1Color))]
    /// <summary>
    /// Light 1.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Light1Color { get => _Light1Color; set => UpdateField(ref _Light1Color, value, nameof(Light1Color)); }

    private IDrawingColor? _Light1Color;
    /// <summary>
    /// Dark 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Dark2Color))]
    /// <summary>
    /// Dark 2.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Dark2Color { get => _Dark2Color; set => UpdateField(ref _Dark2Color, value, nameof(Dark2Color)); }

    private IDrawingColor? _Dark2Color;
    /// <summary>
    /// Light 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Light2Color))]
    /// <summary>
    /// Light 2.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Light2Color { get => _Light2Color; set => UpdateField(ref _Light2Color, value, nameof(Light2Color)); }

    private IDrawingColor? _Light2Color;
    /// <summary>
    /// Accent 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent1Color))]
    /// <summary>
    /// Accent 1.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent1Color { get => _Accent1Color; set => UpdateField(ref _Accent1Color, value, nameof(Accent1Color)); }

    private IDrawingColor? _Accent1Color;
    /// <summary>
    /// Accent 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent2Color))]
    /// <summary>
    /// Accent 2.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent2Color { get => _Accent2Color; set => UpdateField(ref _Accent2Color, value, nameof(Accent2Color)); }

    private IDrawingColor? _Accent2Color;
    /// <summary>
    /// Accent 3.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent3Color))]
    /// <summary>
    /// Accent 3.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent3Color { get => _Accent3Color; set => UpdateField(ref _Accent3Color, value, nameof(Accent3Color)); }

    private IDrawingColor? _Accent3Color;
    /// <summary>
    /// Accent 4.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent4Color))]
    /// <summary>
    /// Accent 4.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent4Color { get => _Accent4Color; set => UpdateField(ref _Accent4Color, value, nameof(Accent4Color)); }

    private IDrawingColor? _Accent4Color;
    /// <summary>
    /// Accent 5.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent5Color))]
    /// <summary>
    /// Accent 5.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent5Color { get => _Accent5Color; set => UpdateField(ref _Accent5Color, value, nameof(Accent5Color)); }

    private IDrawingColor? _Accent5Color;
    /// <summary>
    /// Accent 6.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent6Color))]
    /// <summary>
    /// Accent 6.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Accent6Color { get => _Accent6Color; set => UpdateField(ref _Accent6Color, value, nameof(Accent6Color)); }

    private IDrawingColor? _Accent6Color;
    /// <summary>
    /// Hyperlink.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Hyperlink))]
    /// <summary>
    /// Hyperlink.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }

    private IDrawingColor? _Hyperlink;
    /// <summary>
    /// Followed hyperlink.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.FollowedHyperlinkColor))]
    /// <summary>
    /// Followed hyperlink.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
    public IDrawingColor? FollowedHyperlinkColor { get => _FollowedHyperlinkColor; set => UpdateField(ref _FollowedHyperlinkColor, value, nameof(FollowedHyperlinkColor)); }

    private IDrawingColor? _FollowedHyperlinkColor;
    /// <summary>
    /// List of extensions associated with this object.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.ExtensionList))]
    /// <summary>
    /// List of extensions associated with this object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorScheme))]
#endregion
    /// <summary>
    /// List of extensions associated with this object.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
    /// <summary>
    /// OfficeArtExtensionList.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.OfficeArtExtensionList))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}
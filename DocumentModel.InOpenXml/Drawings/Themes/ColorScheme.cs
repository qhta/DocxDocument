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
    /// Name.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Dark 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Dark1Color))]
#region specific color definitions
    public ColorType? Dark1Color { get; set; }

    /// <summary>
    /// Light 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Light1Color))]
    public ColorType? Light1Color { get; set; }

    /// <summary>
    /// Dark 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Dark2Color))]
    public ColorType? Dark2Color { get; set; }

    /// <summary>
    /// Light 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Light2Color))]
    public ColorType? Light2Color { get; set; }

    /// <summary>
    /// Accent 1.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent1Color))]
    public ColorType? Accent1Color { get; set; }

    /// <summary>
    /// Accent 2.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent2Color))]
    public ColorType? Accent2Color { get; set; }

    /// <summary>
    /// Accent 3.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent3Color))]
    public ColorType? Accent3Color { get; set; }

    /// <summary>
    /// Accent 4.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent4Color))]
    public ColorType? Accent4Color { get; set; }

    /// <summary>
    /// Accent 5.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent5Color))]
    public ColorType? Accent5Color { get; set; }

    /// <summary>
    /// Accent 6.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Accent6Color))]
    public ColorType? Accent6Color { get; set; }

    /// <summary>
    /// Hyperlink.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.Hyperlink))]
    public ColorType? Hyperlink { get; set; }

    /// <summary>
    /// Followed hyperlink.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.FollowedHyperlinkColor))]
    public ColorType? FollowedHyperlinkColor { get; set; }

    /// <summary>
    /// List of extensions associated with this object.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorScheme.ExtensionList))]
#endregion
    public ExtensionList? ExtensionList { get; set; }

    /// <summary>
    /// OfficeArtExtensionList.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.OfficeArtExtensionList))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
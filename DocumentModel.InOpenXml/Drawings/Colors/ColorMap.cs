namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color map for drawing elements.
/// </summary>
public partial class ColorMap : ModelElement<DXD.ColorMap>
{
    /// <summary>
    /// Background 1 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Background1))]
    /// <summary>
    /// Background 1 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Background1 { get => _Background1; set => UpdateField(ref _Background1, value, nameof(Background1)); }

    private string? _Background1;
    /// <summary>
    /// Text 1 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Text1))]
    /// <summary>
    /// Text 1 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Text1 { get => _Text1; set => UpdateField(ref _Text1, value, nameof(Text1)); }

    private string? _Text1;
    /// <summary>
    /// Background 2 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Background2))]
    /// <summary>
    /// Background 2 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Background2 { get => _Background2; set => UpdateField(ref _Background2, value, nameof(Background2)); }

    private string? _Background2;
    /// <summary>
    /// Text 2 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Text2))]
    /// <summary>
    /// Text 2 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Text2 { get => _Text2; set => UpdateField(ref _Text2, value, nameof(Text2)); }

    private string? _Text2;
    /// <summary>
    /// Accent 1 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent1))]
    /// <summary>
    /// Accent 1 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent1 { get => _Accent1; set => UpdateField(ref _Accent1, value, nameof(Accent1)); }

    private string? _Accent1;
    /// <summary>
    /// Accent 2 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent2))]
    /// <summary>
    /// Accent 2 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent2 { get => _Accent2; set => UpdateField(ref _Accent2, value, nameof(Accent2)); }

    private string? _Accent2;
    /// <summary>
    /// Accent 3 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent3))]
    /// <summary>
    /// Accent 3 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent3 { get => _Accent3; set => UpdateField(ref _Accent3, value, nameof(Accent3)); }

    private string? _Accent3;
    /// <summary>
    /// Accent 4 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent4))]
    /// <summary>
    /// Accent 4 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent4 { get => _Accent4; set => UpdateField(ref _Accent4, value, nameof(Accent4)); }

    private string? _Accent4;
    /// <summary>
    /// Accent 5 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent5))]
    /// <summary>
    /// Accent 5 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent5 { get => _Accent5; set => UpdateField(ref _Accent5, value, nameof(Accent5)); }

    private string? _Accent5;
    /// <summary>
    /// Accent 6 color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Accent6))]
    /// <summary>
    /// Accent 6 color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Accent6 { get => _Accent6; set => UpdateField(ref _Accent6, value, nameof(Accent6)); }

    private string? _Accent6;
    /// <summary>
    /// Hyperlink color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.Hyperlink))]
    /// <summary>
    /// Hyperlink color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }

    private string? _Hyperlink;
    /// <summary>
    /// Followed hyperlink color mapping.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorMap.FollowedHyperlink))]
    /// <summary>
    /// Followed hyperlink color mapping.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorMap))]
    public string? FollowedHyperlink { get => _FollowedHyperlink; set => UpdateField(ref _FollowedHyperlink, value, nameof(FollowedHyperlink)); }

    private string? _FollowedHyperlink;
}
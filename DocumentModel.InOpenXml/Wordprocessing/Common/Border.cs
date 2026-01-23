namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a border definition for elements in a WordprocessingML document.
/// This class provides properties for border style, color, width, spacing, shadow, and frame effect, enabling advanced formatting and visual separation of document content.
/// </summary>
public partial class Border : ModelElement<DXW.Border>
{
    /// <summary>
    /// Border style, specifying the type of border (e.g., single, double, dashed).
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public BorderKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private BorderKind? _Type;
    /// <summary>
    /// Border color, specified as an abstract color value.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.Border.Color))]
    /// <summary>
    /// Border color, specified as an abstract color value.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public DocumentModel.Color? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

    private DocumentModel.Color? _Color;
    /// <summary>
    /// Border width, specified in twips.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private Twips? _Width;
    /// <summary>
    /// Border spacing measurement, specifying the space between the border and the content.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.Border.Space))]
    /// <summary>
    /// Border spacing measurement, specifying the space between the border and the content.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public Twips? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }

    private Twips? _Space;
    /// <summary>
    /// Indicates whether the border has a shadow effect.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.Border.Shadow))]
    /// <summary>
    /// Indicates whether the border has a shadow effect.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public bool? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

    private bool? _Shadow;
    /// <summary>
    /// Indicates whether the border has a frame effect.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.Border.Frame))]
    /// <summary>
    /// Indicates whether the border has a frame effect.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Border))]
    public bool? Frame { get => _Frame; set => UpdateField(ref _Frame, value, nameof(Frame)); }

    private bool? _Frame;
}
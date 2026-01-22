namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a font, including its identifier and color information in various color models.
/// </summary>
public partial class FontReference : ModelElement<DXD.FontReference>
{
    /// <summary>
    ///   Identifier for the font collection index.
    /// </summary>
    public FontCollectionIndexKind? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

    private FontCollectionIndexKind? _Index;
    /// <summary>
    ///   Color specified using the RGB color model with percentage values.
    /// </summary>
    public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
    /// <summary>
    ///   Color specified using the RGB color model with hexadecimal values.
    /// </summary>
    public RgbColorModelHex? RgbColorModelHex { get; set; }
    /// <summary>
    ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
    /// </summary>
    public HslColor? HslColor { get; set; }
    /// <summary>
    ///   Color specified using a system-defined color.
    /// </summary>
    public SystemColor? SystemColor { get; set; }
    /// <summary>
    ///   Color specified using a color scheme.
    /// </summary>
    public SchemeColor? SchemeColor { get; set; }
    /// <summary>
    ///   Color specified using a preset color.
    /// </summary>
    public PresetColor? PresetColor { get; set; }
}
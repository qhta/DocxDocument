namespace DocumentModel.Drawings;
/// <summary>
///   Fill Reference.
/// </summary>
public partial class FillReference : ModelElement<DXD.FillReference>
{
    [OpenXmlProperty(nameof(DXD.FillReference.RgbColorModelPercentage))]
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    [OpenXmlProperty(nameof(DXD.FillReference.RgbColorModelHex))]
    public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

    private RgbColorModelHex? _RgbColorModelHex;
    [OpenXmlProperty(nameof(DXD.FillReference.HslColor))]
    public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

    private HslColor? _HslColor;
    [OpenXmlProperty(nameof(DXD.FillReference.SystemColor))]
    public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

    private SystemColor? _SystemColor;
    [OpenXmlProperty(nameof(DXD.FillReference.SchemeColor))]
    public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

    private SchemeColor? _SchemeColor;
    [OpenXmlProperty(nameof(DXD.FillReference.PresetColor))]
    public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

    private PresetColor? _PresetColor;
}
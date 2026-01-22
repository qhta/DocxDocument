namespace DocumentModel.Drawings;
/// <summary>
///   Fill Reference.
/// </summary>
public partial class FillReference : ModelElement<DXD.FillReference>
{
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    public RgbColorModelHex? RgbColorModelHex { get; set; }
    public HslColor? HslColor { get; set; }
    public SystemColor? SystemColor { get; set; }
    public SchemeColor? SchemeColor { get; set; }
    public PresetColor? PresetColor { get; set; }
}
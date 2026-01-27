namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reference to a style matrix entry, including index and color information in multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.StyleMatrixReferenceType))]
public partial class StyleMatrixReferenceType: ModelElement<DXD.StyleMatrixReferenceType>
{
  /// <summary>
  ///   Index into the style matrix.
  /// </summary>
  public UInt32? Index
  {
    get => _Index;
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => _RgbColorModelPercentage;
    set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage));
  }

  private RgbColorModelPercentage? _RgbColorModelPercentage;

  /// <summary>
  ///   Color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get => _RgbColorModelHex;
    set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex));
  }

  private RgbColorModelHex? _RgbColorModelHex;

  /// <summary>
  ///   Color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor
  {
    get => _HslColor;
    set => UpdateField(ref _HslColor, value, nameof(HslColor));
  }

  private HslColor? _HslColor;

  /// <summary>
  ///   Color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor
  {
    get => _SystemColor;
    set => UpdateField(ref _SystemColor, value, nameof(SystemColor));
  }

  private SystemColor? _SystemColor;

  /// <summary>
  ///   Color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get => _SchemeColor;
    set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor));
  }

  private SchemeColor? _SchemeColor;

  /// <summary>
  ///   Color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor
  {
    get => _PresetColor;
    set => UpdateField(ref _PresetColor, value, nameof(PresetColor));
  }

  private PresetColor? _PresetColor;
}
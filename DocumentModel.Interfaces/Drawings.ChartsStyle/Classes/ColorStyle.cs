namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public interface ColorStyle: IModelElement
{
  /// <summary>
  ///   meth
  /// </summary>
  public string? Method { get; set; }
  /// <summary>
  ///   id
  /// </summary>
  public UInt32? Id { get; set; }
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public HslColor? HslColor { get; set; }
  public SystemColor? SystemColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
  public PresetColor? PresetColor { get; set; }
  public Collection<ColorStyleVariation>? ColorStyleVariations { get; set; }
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
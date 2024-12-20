namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public class ColorStyle: ModelElement
{
  /// <summary>
  ///   meth, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Method { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
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
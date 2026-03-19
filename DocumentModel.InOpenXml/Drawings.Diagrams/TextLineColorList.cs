namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Text Line Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.TextLineColorList))]
/// <summary>
/// Represents the Text Line Color List.
/// </summary>
public class TextLineColorList: ColorsType
{
  /// <summary>
  /// Rgb Color Model Percentage.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  /// <summary>
  /// Rgb Color Model Hex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  /// Hsl Color.
  /// </summary>
  public HslColor? HslColor { get; set; }
  /// <summary>
  /// System Color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
  /// <summary>
  /// Preset Color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}


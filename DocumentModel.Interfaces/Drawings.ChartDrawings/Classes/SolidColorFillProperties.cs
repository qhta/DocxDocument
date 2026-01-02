namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public class SolidColorFillProperties: ModelElement
{
  /// <summary>
  /// Rgb color in hex model
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  /// Scheme color
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
  /// <summary>
  /// Rgb color in percentage model
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  /// <summary>
  /// Hsl Color model
  /// </summary>
  public HslColor? HslColor { get; set; }
  /// <summary>
  /// System color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  /// <summary>
  /// Preset color
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}
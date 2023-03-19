namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public class MinColorSolidColorFillProperties: ModelElement
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public HslColor? HslColor { get; set; }

  public SystemColor? SystemColor { get; set; }

  public SchemeColor? SchemeColor { get; set; }

  public PresetColor? PresetColor { get; set; }
}
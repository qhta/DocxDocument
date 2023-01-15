namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public class MaxColorSolidColorFillProperties
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public HslColor? HslColor { get; set; }

  public SystemColor? SystemColor { get; set; }

  public SchemeColor? SchemeColor { get; set; }

  public PresetColor? PresetColor { get; set; }
}
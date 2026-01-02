namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the EffectReference Class.
/// </summary>
public class EffectReference: ModelElement
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public HslColor? HslColor { get; set; }
  public SystemColor? SystemColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
  public PresetColor? PresetColor { get; set; }
  public StyleColor? StyleColor { get; set; }
}
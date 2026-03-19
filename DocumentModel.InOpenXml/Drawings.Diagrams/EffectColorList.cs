namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Effect Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.EffectColorList))]
public class EffectColorList: ColorsType
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public HslColor? HslColor { get; set; }
  public SystemColor? SystemColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
  public PresetColor? PresetColor { get; set; }
}
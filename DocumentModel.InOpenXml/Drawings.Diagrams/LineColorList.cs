namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Line Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.LineColorList))]
public class LineColorList: ColorsType
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public HslColor? HslColor { get; set; }
  public SystemColor? SystemColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
  public PresetColor? PresetColor { get; set; }
}
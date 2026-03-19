namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Fill Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.FillColorList))]
public class FillColorList: ColorsType
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public HslColor? HslColor { get; set; }
  public SystemColor? SystemColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
  public PresetColor? PresetColor { get; set; }
}
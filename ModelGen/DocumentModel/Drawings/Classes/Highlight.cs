namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Highlight Class.
/// </summary>
public partial class Highlight
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

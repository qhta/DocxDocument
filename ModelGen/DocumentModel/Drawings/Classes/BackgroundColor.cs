namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the background color of a Pattern fill.
/// </summary>
public partial class BackgroundColor
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the color which replaces the clrFrom in a clrChange effect. This is the &quot;target&quot; or &quot;to&quot; color in the color change effect.
/// </summary>
public partial class ColorTo
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

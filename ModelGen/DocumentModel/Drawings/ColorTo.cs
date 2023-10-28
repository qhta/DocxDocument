namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the color which replaces the clrFrom in a clrChange effect. This is the &quot;target&quot; or &quot;to&quot; color in the color change effect.
/// </summary>
public partial class ColorTo
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}

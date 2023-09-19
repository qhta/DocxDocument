namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the color which replaces the clrFrom in a clrChange effect. This is the &quot;target&quot; or &quot;to&quot; color in the color change effect.
/// </summary>
public partial class ColorTo
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorValues? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}

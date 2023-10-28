namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the hyperlink color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Hyperlink
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}

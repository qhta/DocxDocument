namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the dark 2 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Dark2Color
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

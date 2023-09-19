namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the followed hyperlink color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class FollowedHyperlinkColor
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}

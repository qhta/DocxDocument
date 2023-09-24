namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the color for the contour on a shape.  The contour of a shape is a solid filled line which surrounds the outer edges of the shape.
/// </summary>
public partial class ContourColor
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

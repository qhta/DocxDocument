namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the color for the contour on a shape.  The contour of a shape is a solid filled line which surrounds the outer edges of the shape.
/// </summary>
public partial class ContourColor
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}

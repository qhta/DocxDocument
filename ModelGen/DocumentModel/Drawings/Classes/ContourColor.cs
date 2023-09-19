namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the color for the contour on a shape.  The contour of a shape is a solid filled line which surrounds the outer edges of the shape.
/// </summary>
public partial class ContourColor
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorValues? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}

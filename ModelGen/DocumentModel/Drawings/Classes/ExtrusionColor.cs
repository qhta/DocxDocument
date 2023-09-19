namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the color of the extrusion applied to a shape.  The extrusion on a shape is an artificial height applied to the geometry.
/// </summary>
public partial class ExtrusionColor
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorValues? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}

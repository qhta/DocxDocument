namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the color of the extrusion applied to a shape.  The extrusion on a shape is an artificial height applied to the geometry.
/// </summary>
public partial class ExtrusionColor
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to a line style within the style matrix.  The idx attribute refers the index of a line style within the fillStyleLst element.
/// </summary>
public partial class LineReference
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

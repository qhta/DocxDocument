namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to a line style within the style matrix.  The idx attribute refers the index of a line style within the fillStyleLst element.
/// </summary>
public partial class LineReference
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}

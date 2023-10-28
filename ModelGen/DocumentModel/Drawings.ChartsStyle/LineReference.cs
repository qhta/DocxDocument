namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LineReference Class.
/// </summary>
public partial class LineReference
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
  public String? StyleColor { get; set; }
  
}

namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to an effect style within the style matrix.  The idx attribute refers the index of an effect style within the effectStyleLst element.
/// </summary>
public partial class EffectReference
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}

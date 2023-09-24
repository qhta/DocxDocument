namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to an effect style within the style matrix.  The idx attribute refers the index of an effect style within the effectStyleLst element.
/// </summary>
public partial class EffectReference
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public HslColor? HslColor { get; set; }
  
  public SystemColor? SystemColor { get; set; }
  
  public SchemeColorKind? SchemeColor { get; set; }
  
  public PresetColorKind? PresetColor { get; set; }
  
}

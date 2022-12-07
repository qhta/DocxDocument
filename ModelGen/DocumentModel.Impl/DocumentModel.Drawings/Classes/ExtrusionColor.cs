namespace DocumentModel.Drawings;

/// <summary>
/// Extrusion Color.
/// </summary>
public class ExtrusionColorImpl: DocumentModel.Drawings.ColorTypeImpl, ExtrusionColor
{
  public override RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public override HslColor? HslColor
  {
    get;
    set;
  }
  
  public override SystemColor? SystemColor
  {
    get;
    set;
  }
  
  public override SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  public override PresetColor? PresetColor
  {
    get;
    set;
  }
  
}

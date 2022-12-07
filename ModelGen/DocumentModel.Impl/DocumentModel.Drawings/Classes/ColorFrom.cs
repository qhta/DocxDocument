namespace DocumentModel.Drawings;

/// <summary>
/// Change Color From.
/// </summary>
public class ColorFromImpl: DocumentModel.Drawings.ColorTypeImpl, ColorFrom
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

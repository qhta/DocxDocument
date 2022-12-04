namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public class MinColorSolidColorFillProperties: DocumentModel.Drawings.OpenXmlSolidColorFillPropertiesElement
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

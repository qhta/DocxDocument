namespace DocumentModel.Drawings;

/// <summary>
/// Color Specified.
/// </summary>
public class BulletColorImpl: DocumentModel.Drawings.ColorTypeImpl, BulletColor
{
  public new DocumentFormat.OpenXml.Drawing.BulletColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BulletColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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

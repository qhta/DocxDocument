namespace DocumentModel.Drawings;

/// <summary>
/// Foreground color.
/// </summary>
public class ForegroundColorImpl: DocumentModel.Drawings.ColorTypeImpl, ForegroundColor
{
  public new DocumentFormat.OpenXml.Drawing.ForegroundColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ForegroundColor?)_OpenXmlElement;
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

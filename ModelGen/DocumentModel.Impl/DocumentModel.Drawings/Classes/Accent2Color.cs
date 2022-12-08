namespace DocumentModel.Drawings;

/// <summary>
/// Accent 2.
/// </summary>
public class Accent2ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent2Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent2Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent2Color?)_OpenXmlElement;
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
  
  public override PresetColor? PresetColor
  {
    get;
    set;
  }
  
}

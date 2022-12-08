namespace DocumentModel.Drawings;

/// <summary>
/// Accent 5.
/// </summary>
public class Accent5ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent5Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent5Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent5Color?)_OpenXmlElement;
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

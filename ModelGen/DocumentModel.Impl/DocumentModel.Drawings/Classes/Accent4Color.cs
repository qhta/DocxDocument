namespace DocumentModel.Drawings;

/// <summary>
/// Accent 4.
/// </summary>
public class Accent4ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent4Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent4Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent4Color?)_OpenXmlElement;
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

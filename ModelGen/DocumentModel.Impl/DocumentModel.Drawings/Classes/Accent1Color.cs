namespace DocumentModel.Drawings;

/// <summary>
/// Accent 1.
/// </summary>
public class Accent1ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent1Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent1Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent1Color?)_OpenXmlElement;
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

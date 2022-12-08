namespace DocumentModel.Drawings;

/// <summary>
/// Accent 3.
/// </summary>
public class Accent3ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent3Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent3Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent3Color?)_OpenXmlElement;
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

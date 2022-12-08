namespace DocumentModel.Drawings;

/// <summary>
/// Light 2.
/// </summary>
public class Light2ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Light2Color
{
  public new DocumentFormat.OpenXml.Drawing.Light2Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Light2Color?)_OpenXmlElement;
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

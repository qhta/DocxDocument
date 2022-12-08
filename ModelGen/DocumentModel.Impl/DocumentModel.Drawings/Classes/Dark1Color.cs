namespace DocumentModel.Drawings;

/// <summary>
/// Dark 1.
/// </summary>
public class Dark1ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Dark1Color
{
  public new DocumentFormat.OpenXml.Drawing.Dark1Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Dark1Color?)_OpenXmlElement;
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

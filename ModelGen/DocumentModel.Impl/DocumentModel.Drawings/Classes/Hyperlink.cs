namespace DocumentModel.Drawings;

/// <summary>
/// Hyperlink.
/// </summary>
public class HyperlinkImpl: DocumentModel.Drawings.Color2TypeImpl, Hyperlink
{
  public new DocumentFormat.OpenXml.Drawing.Hyperlink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Hyperlink?)_OpenXmlElement;
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

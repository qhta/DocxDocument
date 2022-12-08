namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Highlight Class.
/// </summary>
public class HighlightImpl: DocumentModel.Drawings.ColorTypeImpl, Highlight
{
  public new DocumentFormat.OpenXml.Drawing.Highlight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Highlight?)_OpenXmlElement;
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

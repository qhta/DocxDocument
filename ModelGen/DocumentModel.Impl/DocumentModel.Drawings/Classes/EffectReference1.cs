namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectReference Class.
/// </summary>
public class EffectReference1Impl: DocumentModel.Drawings.StyleReferenceImpl, EffectReference1
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public HslColor? HslColor
  {
    get;
    set;
  }
  
  public SystemColor? SystemColor
  {
    get;
    set;
  }
  
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  public PresetColor? PresetColor
  {
    get;
    set;
  }
  
  public StyleColor? StyleColor
  {
    get;
    set;
  }
  
}

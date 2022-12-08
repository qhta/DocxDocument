namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public class LineReference2Impl: DocumentModel.Drawings.StyleReferenceImpl, LineReference2
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference?)_OpenXmlElement;
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

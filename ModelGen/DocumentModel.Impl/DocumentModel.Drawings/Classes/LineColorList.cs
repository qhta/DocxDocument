namespace DocumentModel.Drawings;

/// <summary>
/// Line Color List.
/// </summary>
public class LineColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, LineColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<RgbColorModelPercentage>? RgbColorModelPercentages
  {
    get;
    set;
  }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs
  {
    get;
    set;
  }
  
  public Collection<HslColor>? HslColors
  {
    get;
    set;
  }
  
  public Collection<SystemColor>? SystemColors
  {
    get;
    set;
  }
  
  public Collection<SchemeColor>? SchemeColors
  {
    get;
    set;
  }
  
  public Collection<PresetColor>? PresetColors
  {
    get;
    set;
  }
  
}

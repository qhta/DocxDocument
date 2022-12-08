namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Color List.
/// </summary>
public class TextLineColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, TextLineColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList?)_OpenXmlElement;
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

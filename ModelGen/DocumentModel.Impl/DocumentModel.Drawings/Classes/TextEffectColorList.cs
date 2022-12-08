namespace DocumentModel.Drawings;

/// <summary>
/// Text Effect Color List.
/// </summary>
public class TextEffectColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, TextEffectColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList?)_OpenXmlElement;
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

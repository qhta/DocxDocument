namespace DocumentModel.Drawings;

/// <summary>
/// Effect Color List.
/// </summary>
public class EffectColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, EffectColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList?)_OpenXmlElement;
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

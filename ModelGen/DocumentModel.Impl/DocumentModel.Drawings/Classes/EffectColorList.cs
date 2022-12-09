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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<HslColor>? HslColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SystemColor>? SystemColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SchemeColor>? SchemeColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<PresetColor>? PresetColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

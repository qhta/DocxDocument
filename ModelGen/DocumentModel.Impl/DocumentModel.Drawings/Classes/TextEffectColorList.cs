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

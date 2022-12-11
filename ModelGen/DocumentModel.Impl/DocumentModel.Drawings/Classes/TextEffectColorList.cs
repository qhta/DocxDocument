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
  
  public TextEffectColorListImpl(): base() {}
  
  public TextEffectColorListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

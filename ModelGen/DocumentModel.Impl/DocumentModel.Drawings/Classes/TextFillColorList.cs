namespace DocumentModel.Drawings;

/// <summary>
/// Text Fill Color List.
/// </summary>
public class TextFillColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, TextFillColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextFillColorListImpl(): base() {}
  
  public TextFillColorListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList openXmlElement): base(openXmlElement)
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

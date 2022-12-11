namespace DocumentModel.Drawings;

/// <summary>
/// Fill Color List.
/// </summary>
public class FillColorListImpl: DocumentModel.Drawings.ColorsTypeImpl, FillColorList
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FillColorListImpl(): base() {}
  
  public FillColorListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList openXmlElement): base(openXmlElement)
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

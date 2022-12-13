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
  
  public LineColorListImpl(): base() {}
  
  public LineColorListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

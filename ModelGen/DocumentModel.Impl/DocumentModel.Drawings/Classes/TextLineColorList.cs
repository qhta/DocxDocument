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
  
  public TextLineColorListImpl(): base() {}
  
  public TextLineColorListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList openXmlElement): base(openXmlElement)
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

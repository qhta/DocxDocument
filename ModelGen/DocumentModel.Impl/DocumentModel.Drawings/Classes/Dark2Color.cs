namespace DocumentModel.Drawings;

/// <summary>
/// Dark 2.
/// </summary>
public class Dark2ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Dark2Color
{
  public new DocumentFormat.OpenXml.Drawing.Dark2Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Dark2Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Dark2ColorImpl(): base() {}
  
  public Dark2ColorImpl(DocumentFormat.OpenXml.Drawing.Dark2Color openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

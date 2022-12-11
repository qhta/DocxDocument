namespace DocumentModel.Drawings;

/// <summary>
/// Dark 1.
/// </summary>
public class Dark1ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Dark1Color
{
  public new DocumentFormat.OpenXml.Drawing.Dark1Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Dark1Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Dark1ColorImpl(): base() {}
  
  public Dark1ColorImpl(DocumentFormat.OpenXml.Drawing.Dark1Color openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

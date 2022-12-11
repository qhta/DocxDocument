namespace DocumentModel.Drawings;

/// <summary>
/// Accent 1.
/// </summary>
public class Accent1ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent1Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent1Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent1Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Accent1ColorImpl(): base() {}
  
  public Accent1ColorImpl(DocumentFormat.OpenXml.Drawing.Accent1Color openXmlElement): base(openXmlElement)
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

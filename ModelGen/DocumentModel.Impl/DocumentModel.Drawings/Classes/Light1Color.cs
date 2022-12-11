namespace DocumentModel.Drawings;

/// <summary>
/// Light 1.
/// </summary>
public class Light1ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Light1Color
{
  public new DocumentFormat.OpenXml.Drawing.Light1Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Light1Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Light1ColorImpl(): base() {}
  
  public Light1ColorImpl(DocumentFormat.OpenXml.Drawing.Light1Color openXmlElement): base(openXmlElement)
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

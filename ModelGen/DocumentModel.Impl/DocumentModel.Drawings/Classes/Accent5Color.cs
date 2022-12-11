namespace DocumentModel.Drawings;

/// <summary>
/// Accent 5.
/// </summary>
public class Accent5ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent5Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent5Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent5Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Accent5ColorImpl(): base() {}
  
  public Accent5ColorImpl(DocumentFormat.OpenXml.Drawing.Accent5Color openXmlElement): base(openXmlElement)
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

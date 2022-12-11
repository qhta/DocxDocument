namespace DocumentModel.Drawings;

/// <summary>
/// Accent 2.
/// </summary>
public class Accent2ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent2Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent2Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent2Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Accent2ColorImpl(): base() {}
  
  public Accent2ColorImpl(DocumentFormat.OpenXml.Drawing.Accent2Color openXmlElement): base(openXmlElement)
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

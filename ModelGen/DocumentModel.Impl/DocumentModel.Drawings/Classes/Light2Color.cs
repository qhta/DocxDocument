namespace DocumentModel.Drawings;

/// <summary>
/// Light 2.
/// </summary>
public class Light2ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Light2Color
{
  public new DocumentFormat.OpenXml.Drawing.Light2Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Light2Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Light2ColorImpl(): base() {}
  
  public Light2ColorImpl(DocumentFormat.OpenXml.Drawing.Light2Color openXmlElement): base(openXmlElement)
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

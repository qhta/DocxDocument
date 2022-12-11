namespace DocumentModel.Drawings;

/// <summary>
/// Background color.
/// </summary>
public class BackgroundColorImpl: DocumentModel.Drawings.ColorTypeImpl, BackgroundColor
{
  public new DocumentFormat.OpenXml.Drawing.BackgroundColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BackgroundColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundColorImpl(): base() {}
  
  public BackgroundColorImpl(DocumentFormat.OpenXml.Drawing.BackgroundColor openXmlElement): base(openXmlElement)
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
  
  public new SchemeColor? SchemeColor
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

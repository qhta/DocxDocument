namespace DocumentModel.Drawings;

/// <summary>
/// Contour Color.
/// </summary>
public class ContourColorImpl: DocumentModel.Drawings.ColorTypeImpl, ContourColor
{
  public new DocumentFormat.OpenXml.Drawing.ContourColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ContourColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ContourColorImpl(): base() {}
  
  public ContourColorImpl(DocumentFormat.OpenXml.Drawing.ContourColor openXmlElement): base(openXmlElement)
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

namespace DocumentModel.Drawings;

/// <summary>
/// Change Color To.
/// </summary>
public class ColorToImpl: DocumentModel.Drawings.ColorTypeImpl, ColorTo
{
  public new DocumentFormat.OpenXml.Drawing.ColorTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorToImpl(): base() {}
  
  public ColorToImpl(DocumentFormat.OpenXml.Drawing.ColorTo openXmlElement): base(openXmlElement)
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
  
  public new DocumentModel.Drawings.SchemeColor? SchemeColor
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

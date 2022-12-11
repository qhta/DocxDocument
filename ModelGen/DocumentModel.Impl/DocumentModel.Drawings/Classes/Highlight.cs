namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Highlight Class.
/// </summary>
public class HighlightImpl: DocumentModel.Drawings.ColorTypeImpl, Highlight
{
  public new DocumentFormat.OpenXml.Drawing.Highlight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Highlight?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HighlightImpl(): base() {}
  
  public HighlightImpl(DocumentFormat.OpenXml.Drawing.Highlight openXmlElement): base(openXmlElement)
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

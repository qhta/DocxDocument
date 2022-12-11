namespace DocumentModel.Drawings;

/// <summary>
/// Hyperlink.
/// </summary>
public class HyperlinkImpl: DocumentModel.Drawings.Color2TypeImpl, Hyperlink
{
  public new DocumentFormat.OpenXml.Drawing.Hyperlink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Hyperlink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkImpl(): base() {}
  
  public HyperlinkImpl(DocumentFormat.OpenXml.Drawing.Hyperlink openXmlElement): base(openXmlElement)
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

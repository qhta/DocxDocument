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

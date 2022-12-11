namespace DocumentModel.Drawings;

/// <summary>
/// Followed Hyperlink.
/// </summary>
public class FollowedHyperlinkColorImpl: DocumentModel.Drawings.Color2TypeImpl, FollowedHyperlinkColor
{
  public new DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FollowedHyperlinkColorImpl(): base() {}
  
  public FollowedHyperlinkColorImpl(DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor openXmlElement): base(openXmlElement)
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

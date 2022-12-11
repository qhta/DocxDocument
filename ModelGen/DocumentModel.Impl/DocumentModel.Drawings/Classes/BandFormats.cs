namespace DocumentModel.Drawings;

/// <summary>
/// Band Formats.
/// </summary>
public class BandFormatsImpl: ModelElementImpl, BandFormats
{
  public DocumentFormat.OpenXml.Drawing.Charts.BandFormats? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BandFormats?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BandFormatsImpl(): base() {}
  
  public BandFormatsImpl(DocumentFormat.OpenXml.Drawing.Charts.BandFormats openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<BandFormat>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

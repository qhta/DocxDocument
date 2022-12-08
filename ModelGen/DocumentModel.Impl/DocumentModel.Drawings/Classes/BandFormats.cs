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
  
  public Collection<BandFormat>? Items
  {
    get;
    set;
  }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PictureAttributionSourceURL Class.
/// </summary>
public class PictureAttributionSourceURLImpl: ModelElementImpl, PictureAttributionSourceURL
{
  public DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}

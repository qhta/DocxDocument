namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public class ArtisticBlurImpl: ModelElementImpl, ArtisticBlur
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticBlurImpl(): base() {}
  
  public ArtisticBlurImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius
  {
    get => (System.Int32?)OpenXmlElement?.Radius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Radius = (System.Int32?)value;
    }
  }
  
}

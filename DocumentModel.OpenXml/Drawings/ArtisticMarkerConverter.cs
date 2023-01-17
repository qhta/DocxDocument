namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticMarker Class.
/// </summary>
public static class ArtisticMarkerConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker openXmlElement)
  {
    return openXmlElement.Size?.Value;
  }
  
  private static void SetSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker openXmlElement, Int32? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DocumentModel.Drawings.ArtisticMarker? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticMarker();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticMarker? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSize(openXmlElement, value?.Size);
      return openXmlElement;
    }
    return default;
  }
}

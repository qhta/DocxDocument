namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public static class ArtisticBlurConverter
{
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRadius(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur openXmlElement)
  {
    return openXmlElement.Radius?.Value;
  }
  
  private static void SetRadius(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur openXmlElement, Int32? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.ArtisticBlur? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticBlur();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticBlur? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
      return openXmlElement;
    }
    return default;
  }
}

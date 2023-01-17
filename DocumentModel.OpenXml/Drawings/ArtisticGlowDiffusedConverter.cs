namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public static class ArtisticGlowDiffusedConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetIntensity(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement.Intensity?.Value;
  }
  
  private static void SetIntensity(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Intensity = value;
  }
  
  public static DocumentModel.Drawings.ArtisticGlowDiffused? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlowDiffused();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticGlowDiffused? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetIntensity(openXmlElement, value?.Intensity);
      return openXmlElement;
    }
    return default;
  }
}

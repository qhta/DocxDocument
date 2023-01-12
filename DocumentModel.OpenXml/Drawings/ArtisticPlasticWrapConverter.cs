namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public static class ArtisticPlasticWrapConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSmoothness(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? openXmlElement)
  {
    return openXmlElement?.Smoothness?.Value;
  }
  
  public static void SetSmoothness(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Smoothness = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPlasticWrap? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPlasticWrap();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPlasticWrap? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSmoothness(openXmlElement, value?.Smoothness);
      return openXmlElement;
    }
    return default;
  }
}

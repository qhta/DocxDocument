namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public static class ArtisticGlowEdgesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement.Smoothness?.Value;
  }
  
  private static void SetSmoothness(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DocumentModel.Drawings.ArtisticGlowEdges? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlowEdges();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticGlowEdges? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges, new()
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

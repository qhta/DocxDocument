namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public static class ArtisticCementConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetCrackSpacing(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? openXmlElement)
  {
    return openXmlElement?.CrackSpacing?.Value;
  }
  
  public static void SetCrackSpacing(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CrackSpacing = value;
  }
  
  public static DocumentModel.Drawings.ArtisticCement? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCement();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.CrackSpacing = GetCrackSpacing(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticCement? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

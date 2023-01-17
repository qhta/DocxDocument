namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public static class ArtisticPhotocopyConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDetail(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement.Detail?.Value;
  }
  
  private static void SetDetail(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Detail = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPhotocopy? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPhotocopy();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Detail = GetDetail(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPhotocopy? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetDetail(openXmlElement, value?.Detail);
      return openXmlElement;
    }
    return default;
  }
}

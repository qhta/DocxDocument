namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public static class ArtisticPhotocopyConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement.Detail?.Value;
  }
  
  private static void SetDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Detail = value;
  }
  
  public static DMDraws.ArtisticPhotocopy? CreateModelElement(DXO2010Draw.ArtisticPhotocopy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPhotocopy();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Detail = GetDetail(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPhotocopy? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPhotocopy, new()
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

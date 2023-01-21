namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXDrawW.Extent openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DXDrawW.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXDrawW.Extent openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DXDrawW.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMDrawsW.Extent? CreateModelElement(DXDrawW.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.Extent? value)
    where OpenXmlElementType: DXDrawW.Extent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}

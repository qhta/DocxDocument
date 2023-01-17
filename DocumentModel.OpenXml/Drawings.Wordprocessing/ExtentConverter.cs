namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.Extent? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Extent? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent, new()
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

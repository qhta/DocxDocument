namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public static class AlphaOutsetConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DocumentFormat.OpenXml.Drawing.AlphaOutset openXmlElement)
  {
    return openXmlElement.Radius?.Value;
  }
  
  private static void SetRadius(DocumentFormat.OpenXml.Drawing.AlphaOutset openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.AlphaOutset? CreateModelElement(DocumentFormat.OpenXml.Drawing.AlphaOutset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaOutset();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaOutset? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AlphaOutset, new()
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

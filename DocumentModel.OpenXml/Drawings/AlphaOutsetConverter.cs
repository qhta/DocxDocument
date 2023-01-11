namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public static class AlphaOutsetConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  public static Int64? GetRadius(DocumentFormat.OpenXml.Drawing.AlphaOutset? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  public static void SetRadius(DocumentFormat.OpenXml.Drawing.AlphaOutset? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

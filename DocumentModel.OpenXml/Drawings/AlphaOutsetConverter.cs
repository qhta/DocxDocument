namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public static class AlphaOutsetConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXDraw.AlphaOutset openXmlElement)
  {
    return openXmlElement.Radius?.Value;
  }
  
  private static void SetRadius(DXDraw.AlphaOutset openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DMDraws.AlphaOutset? CreateModelElement(DXDraw.AlphaOutset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AlphaOutset();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaOutset? value)
    where OpenXmlElementType: DXDraw.AlphaOutset, new()
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

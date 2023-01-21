namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public static class BlurConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXDraw.Blur openXmlElement)
  {
    return openXmlElement.Radius?.Value;
  }
  
  private static void SetRadius(DXDraw.Blur openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  private static Boolean? GetGrow(DXDraw.Blur openXmlElement)
  {
    return openXmlElement?.Grow?.Value;
  }
  
  private static void SetGrow(DXDraw.Blur openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grow = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Grow = null;
  }
  
  public static DMDraws.Blur? CreateModelElement(DXDraw.Blur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Blur();
      value.Radius = GetRadius(openXmlElement);
      value.Grow = GetGrow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Blur? value)
    where OpenXmlElementType: DXDraw.Blur, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
      SetGrow(openXmlElement, value?.Grow);
      return openXmlElement;
    }
    return default;
  }
}

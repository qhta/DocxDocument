namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public static class BlurConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  public static Int64? GetRadius(DocumentFormat.OpenXml.Drawing.Blur? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  public static void SetRadius(DocumentFormat.OpenXml.Drawing.Blur? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Radius = value;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public static Boolean? GetGrow(DocumentFormat.OpenXml.Drawing.Blur? openXmlElement)
  {
    return openXmlElement?.Grow?.Value;
  }
  
  public static void SetGrow(DocumentFormat.OpenXml.Drawing.Blur? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Grow = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Grow = null;
  }
  
  public static DocumentModel.Drawings.Blur? CreateModelElement(DocumentFormat.OpenXml.Drawing.Blur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blur();
      value.Radius = GetRadius(openXmlElement);
      value.Grow = GetGrow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Blur? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Blur, new()
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

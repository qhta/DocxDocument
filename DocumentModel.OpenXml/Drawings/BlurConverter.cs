using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Blur Class.
/// </summary>
public static class BlurConverter
{
  /// <summary>
  ///   Radius
  /// </summary>
  public static Int64? GetRadius(Blur? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }

  public static void SetRadius(Blur? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Radius = value;
  }

  /// <summary>
  ///   Grow Bounds
  /// </summary>
  public static Boolean? GetGrow(Blur? openXmlElement)
  {
    return openXmlElement?.Grow?.Value;
  }

  public static void SetGrow(Blur? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Grow = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Grow = null;
  }

  public static DocumentModel.Drawings.Blur? CreateModelElement(Blur? openXmlElement)
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
    where OpenXmlElementType : Blur, new()
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
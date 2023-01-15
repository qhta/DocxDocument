using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Linear Gradient Fill.
/// </summary>
public static class LinearGradientFillConverter
{
  /// <summary>
  ///   Angle
  /// </summary>
  public static Int32? GetAngle(LinearGradientFill? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }

  public static void SetAngle(LinearGradientFill? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }

  /// <summary>
  ///   Scaled
  /// </summary>
  public static Boolean? GetScaled(LinearGradientFill? openXmlElement)
  {
    return openXmlElement?.Scaled?.Value;
  }

  public static void SetScaled(LinearGradientFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Scaled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Scaled = null;
  }

  public static DocumentModel.Drawings.LinearGradientFill? CreateModelElement(LinearGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinearGradientFill();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinearGradientFill? value)
    where OpenXmlElementType : LinearGradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetScaled(openXmlElement, value?.Scaled);
      return openXmlElement;
    }
    return default;
  }
}
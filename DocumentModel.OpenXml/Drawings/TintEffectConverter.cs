using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the TintEffect Class.
/// </summary>
public static class TintEffectConverter
{
  /// <summary>
  ///   Hue
  /// </summary>
  public static Int32? GetHue(TintEffect? openXmlElement)
  {
    return openXmlElement?.Hue?.Value;
  }

  public static void SetHue(TintEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hue = value;
  }

  /// <summary>
  ///   Amount
  /// </summary>
  public static Int32? GetAmount(TintEffect? openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }

  public static void SetAmount(TintEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Amount = value;
  }

  public static DocumentModel.Drawings.TintEffect? CreateModelElement(TintEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TintEffect();
      value.Hue = GetHue(openXmlElement);
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TintEffect? value)
    where OpenXmlElementType : TintEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHue(openXmlElement, value?.Hue);
      SetAmount(openXmlElement, value?.Amount);
      return openXmlElement;
    }
    return default;
  }
}
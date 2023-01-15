using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using ColorsType = DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  ///   Color Application Method Type
  /// </summary>
  public static ColorApplicationMethodKind? GetMethod(ColorsType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorApplicationMethodValues, ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }

  public static void SetMethod(ColorsType? openXmlElement, ColorApplicationMethodKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Method = EnumValueConverter.CreateEnumValue<ColorApplicationMethodValues, ColorApplicationMethodKind>(value);
  }

  /// <summary>
  ///   Hue Direction
  /// </summary>
  public static HueDirectionKind? GetHueDirection(ColorsType? openXmlElement)
  {
    return EnumValueConverter.GetValue<HueDirectionValues, HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }

  public static void SetHueDirection(ColorsType? openXmlElement, HueDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<HueDirectionValues, HueDirectionKind>(value);
  }

  public static DocumentModel.Drawings.Diagrams.ColorsType? CreateModelElement(ColorsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorsType();
      value.Method = GetMethod(openXmlElement);
      value.HueDirection = GetHueDirection(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorsType? value)
    where OpenXmlElementType : ColorsType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMethod(openXmlElement, value?.Method);
      SetHueDirection(openXmlElement, value?.HueDirection);
      return openXmlElement;
    }
    return default;
  }
}
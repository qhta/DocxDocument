using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using LineEndPropertiesType = DocumentFormat.OpenXml.Drawing.LineEndPropertiesType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LineEndPropertiesType Class.
/// </summary>
public static class LineEndPropertiesTypeConverter
{
  /// <summary>
  ///   Line Head/End Type
  /// </summary>
  public static LineEndKind? GetType(LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineEndValues, LineEndKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(LineEndPropertiesType? openXmlElement, LineEndKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<LineEndValues, LineEndKind>(value);
  }

  /// <summary>
  ///   Width of Head/End
  /// </summary>
  public static LineEndWidthKind? GetWidth(LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineEndWidthValues, LineEndWidthKind>(openXmlElement?.Width?.Value);
  }

  public static void SetWidth(LineEndPropertiesType? openXmlElement, LineEndWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = EnumValueConverter.CreateEnumValue<LineEndWidthValues, LineEndWidthKind>(value);
  }

  /// <summary>
  ///   Length of Head/End
  /// </summary>
  public static LineEndLengthKind? GetLength(LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineEndLengthValues, LineEndLengthKind>(openXmlElement?.Length?.Value);
  }

  public static void SetLength(LineEndPropertiesType? openXmlElement, LineEndLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Length = EnumValueConverter.CreateEnumValue<LineEndLengthValues, LineEndLengthKind>(value);
  }

  public static DocumentModel.Drawings.LineEndPropertiesType? CreateModelElement(LineEndPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineEndPropertiesType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Length = GetLength(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineEndPropertiesType? value)
    where OpenXmlElementType : LineEndPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetWidth(openXmlElement, value?.Width);
      SetLength(openXmlElement, value?.Length);
      return openXmlElement;
    }
    return default;
  }
}
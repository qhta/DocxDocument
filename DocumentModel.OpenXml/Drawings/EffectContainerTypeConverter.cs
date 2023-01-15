using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using EffectContainerType = DocumentFormat.OpenXml.Drawing.EffectContainerType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the EffectContainerType Class.
/// </summary>
public static class EffectContainerTypeConverter
{
  /// <summary>
  ///   Effect Container Type
  /// </summary>
  public static EffectContainerKind? GetType(EffectContainerType? openXmlElement)
  {
    return EnumValueConverter.GetValue<EffectContainerValues, EffectContainerKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(EffectContainerType? openXmlElement, EffectContainerKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<EffectContainerValues, EffectContainerKind>(value);
  }

  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(EffectContainerType? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(EffectContainerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  public static DocumentModel.Drawings.EffectContainerType? CreateModelElement(EffectContainerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectContainerType();
      value.Type = GetType(openXmlElement);
      value.Name = GetName(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectContainerType? value)
    where OpenXmlElementType : EffectContainerType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetName(openXmlElement, value?.Name);
      return openXmlElement;
    }
    return default;
  }
}
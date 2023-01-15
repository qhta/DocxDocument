using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using BevelType = DocumentFormat.OpenXml.Drawing.BevelType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  ///   Width
  /// </summary>
  public static Int64? GetWidth(BevelType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   Height
  /// </summary>
  public static Int64? GetHeight(BevelType? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   Preset Bevel
  /// </summary>
  public static BevelPresetKind? GetPreset(BevelType? openXmlElement)
  {
    return EnumValueConverter.GetValue<BevelPresetValues, BevelPresetKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(BevelType? openXmlElement, BevelPresetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<BevelPresetValues, BevelPresetKind>(value);
  }

  public static DocumentModel.Drawings.BevelType? CreateModelElement(BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Preset = GetPreset(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BevelType? value)
    where OpenXmlElementType : BevelType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetPreset(openXmlElement, value?.Preset);
      return openXmlElement;
    }
    return default;
  }
}
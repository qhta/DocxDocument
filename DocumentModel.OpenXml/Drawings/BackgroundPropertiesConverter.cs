using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using BackgroundProperties = DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BackgroundProperties Class.
/// </summary>
public static class BackgroundPropertiesConverter
{
  /// <summary>
  ///   bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public static BlackWhiteMode? GetMode(BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackWhiteModeValues, BlackWhiteMode>(openXmlElement?.Mode?.Value);
  }

  public static void SetMode(BackgroundProperties? openXmlElement, BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Mode = EnumValueConverter.CreateEnumValue<BlackWhiteModeValues, BlackWhiteMode>(value);
  }

  /// <summary>
  ///   bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public static BlackWhiteMode? GetPure(BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackWhiteModeValues, BlackWhiteMode>(openXmlElement?.Pure?.Value);
  }

  public static void SetPure(BackgroundProperties? openXmlElement, BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pure = EnumValueConverter.CreateEnumValue<BlackWhiteModeValues, BlackWhiteMode>(value);
  }

  /// <summary>
  ///   bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public static BlackWhiteMode? GetNormal(BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackWhiteModeValues, BlackWhiteMode>(openXmlElement?.Normal?.Value);
  }

  public static void SetNormal(BackgroundProperties? openXmlElement, BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Normal = EnumValueConverter.CreateEnumValue<BlackWhiteModeValues, BlackWhiteMode>(value);
  }

  /// <summary>
  ///   targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public static TargetScreenSize? GetTargetScreenSize(BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value);
  }

  public static void SetTargetScreenSize(BackgroundProperties? openXmlElement, TargetScreenSize? value)
  {
    if (openXmlElement != null)
      openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, TargetScreenSize>(value);
  }

  public static DocumentModel.Drawings.BackgroundProperties? CreateModelElement(BackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundProperties();
      value.Mode = GetMode(openXmlElement);
      value.Pure = GetPure(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundProperties? value)
    where OpenXmlElementType : BackgroundProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMode(openXmlElement, value?.Mode);
      SetPure(openXmlElement, value?.Pure);
      SetNormal(openXmlElement, value?.Normal);
      SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
      return openXmlElement;
    }
    return default;
  }
}
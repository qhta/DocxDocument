using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using FillExtendedProperties = DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
public static class FillExtendedPropertiesConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(FillExtendedProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(FillExtendedProperties? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Fill Type
  /// </summary>
  public static FillKind? GetType(FillExtendedProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<FillValues, FillKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(FillExtendedProperties? openXmlElement, FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<FillValues, FillKind>(value);
  }

  public static DocumentModel.Vml.FillExtendedProperties? CreateModelElement(FillExtendedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.FillExtendedProperties();
      value.Extension = GetExtension(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.FillExtendedProperties? value)
    where OpenXmlElementType : FillExtendedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
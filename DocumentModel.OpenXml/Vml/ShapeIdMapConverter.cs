using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using ShapeIdMap = DocumentFormat.OpenXml.Vml.Office.ShapeIdMap;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape ID Map.
/// </summary>
public static class ShapeIdMapConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(ShapeIdMap? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(ShapeIdMap? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Shape IDs
  /// </summary>
  public static String? GetData(ShapeIdMap? openXmlElement)
  {
    return openXmlElement?.Data?.Value;
  }

  public static void SetData(ShapeIdMap? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Data = new StringValue { Value = value };
      else
        openXmlElement.Data = null;
  }

  public static DocumentModel.Vml.ShapeIdMap? CreateModelElement(ShapeIdMap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeIdMap();
      value.Extension = GetExtension(openXmlElement);
      value.Data = GetData(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeIdMap? value)
    where OpenXmlElementType : ShapeIdMap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetData(openXmlElement, value?.Data);
      return openXmlElement;
    }
    return default;
  }
}
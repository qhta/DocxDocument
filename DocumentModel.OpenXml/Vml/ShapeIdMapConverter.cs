namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public static class ShapeIdMapConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ShapeIdMap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.ShapeIdMap openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  private static String? GetData(DXVmlO.ShapeIdMap openXmlElement)
  {
    return openXmlElement?.Data?.Value;
  }
  
  private static void SetData(DXVmlO.ShapeIdMap openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Data = new StringValue { Value = value };
    else
      openXmlElement.Data = null;
  }
  
  public static DMVml.ShapeIdMap? CreateModelElement(DXVmlO.ShapeIdMap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ShapeIdMap();
      value.Extension = GetExtension(openXmlElement);
      value.Data = GetData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeIdMap? value)
    where OpenXmlElementType: DXVmlO.ShapeIdMap, new()
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

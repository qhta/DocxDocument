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
  
  private static bool CmpExtension(DXVmlO.ShapeIdMap openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpData(DXVmlO.ShapeIdMap openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Data?.Value == value) return true;
    diffs?.Add(objName, "Data", openXmlElement?.Data?.Value, value);
    return false;
  }
  
  private static void SetData(DXVmlO.ShapeIdMap openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Data = new StringValue { Value = value };
    else
      openXmlElement.Data = null;
  }
  
  public static DocumentModel.Vml.ShapeIdMap? CreateModelElement(DXVmlO.ShapeIdMap? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlO.ShapeIdMap? openXmlElement, DMVml.ShapeIdMap? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpData(openXmlElement, value.Data, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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

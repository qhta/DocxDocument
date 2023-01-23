namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public static class FillExtendedPropertiesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.FillExtendedProperties openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.FillExtendedProperties openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DMVml.FillKind? GetType(DXVmlO.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DMVml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVmlO.FillExtendedProperties openXmlElement, DMVml.FillKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DMVml.FillKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXVmlO.FillExtendedProperties openXmlElement, DMVml.FillKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DMVml.FillKind>(value);
  }
  
  public static DMVml.FillExtendedProperties? CreateModelElement(DXVmlO.FillExtendedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.FillExtendedProperties();
      value.Extension = GetExtension(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.FillExtendedProperties? openXmlElement, DMVml.FillExtendedProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.FillExtendedProperties? value)
    where OpenXmlElementType: DXVmlO.FillExtendedProperties, new()
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

namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Skew Transform.
/// </summary>
public static class SkewConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Skew openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.Skew openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.Skew openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  private static String? GetId(DXVmlO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVmlO.Skew openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  private static Boolean? GetOn(DXVmlO.Skew openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVmlO.Skew openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVmlO.Skew openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  private static String? GetOffset(DXVmlO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Offset);
  }
  
  private static bool CmpOffset(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Offset, value, diffs, objName, "Offset");
  }
  
  private static void SetOffset(DXVmlO.Skew openXmlElement, String? value)
  {
    openXmlElement.Offset = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  private static String? GetOrigin(DXVmlO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Origin);
  }
  
  private static bool CmpOrigin(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Origin, value, diffs, objName, "Origin");
  }
  
  private static void SetOrigin(DXVmlO.Skew openXmlElement, String? value)
  {
    openXmlElement.Origin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXVmlO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Matrix);
  }
  
  private static bool CmpMatrix(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Matrix, value, diffs, objName, "Matrix");
  }
  
  private static void SetMatrix(DXVmlO.Skew openXmlElement, String? value)
  {
    openXmlElement.Matrix = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Skew? CreateModelElement(DXVmlO.Skew? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Skew();
      value.Extension = GetExtension(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Skew? openXmlElement, DMVml.Skew? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpOffset(openXmlElement, value.Offset, diffs, objName))
        ok = false;
      if (!CmpOrigin(openXmlElement, value.Origin, diffs, objName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Skew value)
    where OpenXmlElementType: DXVmlO.Skew, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Skew openXmlElement, DMVml.Skew value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetId(openXmlElement, value?.Id);
    SetOn(openXmlElement, value?.On);
    SetOffset(openXmlElement, value?.Offset);
    SetOrigin(openXmlElement, value?.Origin);
    SetMatrix(openXmlElement, value?.Matrix);
  }
}

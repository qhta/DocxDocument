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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXVmlO.Skew openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
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
    return openXmlElement?.On?.Value == value;
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
    return openXmlElement?.Offset?.Value;
  }
  
  private static bool CmpOffset(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Offset?.Value == value;
  }
  
  private static void SetOffset(DXVmlO.Skew openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Offset = new StringValue { Value = value };
    else
      openXmlElement.Offset = null;
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  private static String? GetOrigin(DXVmlO.Skew openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  private static bool CmpOrigin(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Origin?.Value == value;
  }
  
  private static void SetOrigin(DXVmlO.Skew openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Origin = new StringValue { Value = value };
    else
      openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXVmlO.Skew openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }
  
  private static bool CmpMatrix(DXVmlO.Skew openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Matrix?.Value == value;
  }
  
  private static void SetMatrix(DXVmlO.Skew openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Matrix = new StringValue { Value = value };
    else
      openXmlElement.Matrix = null;
  }
  
  public static DMVml.Skew? CreateModelElement(DXVmlO.Skew? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Skew();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Skew? value)
    where OpenXmlElementType: DXVmlO.Skew, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetId(openXmlElement, value?.Id);
      SetOn(openXmlElement, value?.On);
      SetOffset(openXmlElement, value?.Offset);
      SetOrigin(openXmlElement, value?.Origin);
      SetMatrix(openXmlElement, value?.Matrix);
      return openXmlElement;
    }
    return default;
  }
}

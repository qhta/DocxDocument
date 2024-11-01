namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ColorMenu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.ColorMenu openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.ColorMenu openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  private static String? GetStrokeColor(DXVmlO.ColorMenu openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXVmlO.ColorMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  private static String? GetFillColor(DXVmlO.ColorMenu openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXVmlO.ColorMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  private static String? GetShadowColor(DXVmlO.ColorMenu openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShadowColor);
  }
  
  private static bool CmpShadowColor(DXVmlO.ColorMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShadowColor, value, diffs, objName, "ShadowColor");
  }
  
  private static void SetShadowColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    openXmlElement.ShadowColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  private static String? GetExtrusionColor(DXVmlO.ColorMenu openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ExtrusionColor);
  }
  
  private static bool CmpExtrusionColor(DXVmlO.ColorMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ExtrusionColor, value, diffs, objName, "ExtrusionColor");
  }
  
  private static void SetExtrusionColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    openXmlElement.ExtrusionColor = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ColorMenu? CreateModelElement(DXVmlO.ColorMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ColorMenu();
      value.Extension = GetExtension(openXmlElement);
      value.StrokeColor = GetStrokeColor(openXmlElement);
      value.FillColor = GetFillColor(openXmlElement);
      value.ShadowColor = GetShadowColor(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.ColorMenu? openXmlElement, DMVml.ColorMenu? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpStrokeColor(openXmlElement, value.StrokeColor, diffs, objName))
        ok = false;
      if (!CmpFillColor(openXmlElement, value.FillColor, diffs, objName))
        ok = false;
      if (!CmpShadowColor(openXmlElement, value.ShadowColor, diffs, objName))
        ok = false;
      if (!CmpExtrusionColor(openXmlElement, value.ExtrusionColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ColorMenu value)
    where OpenXmlElementType: DXVmlO.ColorMenu, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.ColorMenu openXmlElement, DMVml.ColorMenu value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetStrokeColor(openXmlElement, value?.StrokeColor);
    SetFillColor(openXmlElement, value?.FillColor);
    SetShadowColor(openXmlElement, value?.ShadowColor);
    SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
  }
}

namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public static class CalloutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.Callout openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.Callout openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  private static Boolean? GetOn(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  private static String? GetType(DXVmlO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXVmlO.Callout openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXVmlO.Callout openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  private static String? GetGap(DXVmlO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Gap);
  }
  
  private static bool CmpGap(DXVmlO.Callout openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Gap, value, diffs, objName, "Gap");
  }
  
  private static void SetGap(DXVmlO.Callout openXmlElement, String? value)
  {
    openXmlElement.Gap = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  private static DMVml.AngleKind? GetAngle(DXVmlO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMVml.AngleKind>(openXmlElement?.Angle?.Value);
  }
  
  private static bool CmpAngle(DXVmlO.Callout openXmlElement, DMVml.AngleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMVml.AngleKind>(openXmlElement?.Angle?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAngle(DXVmlO.Callout openXmlElement, DMVml.AngleKind? value)
  {
    openXmlElement.Angle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMVml.AngleKind>(value);
  }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  private static Boolean? GetDropAuto(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.DropAuto?.Value;
  }
  
  private static bool CmpDropAuto(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DropAuto?.Value == value) return true;
    diffs?.Add(objName, "DropAuto", openXmlElement?.DropAuto?.Value, value);
    return false;
  }
  
  private static void SetDropAuto(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DropAuto = value;
    else
      openXmlElement.DropAuto = null;
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  private static String? GetDrop(DXVmlO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Drop);
  }
  
  private static bool CmpDrop(DXVmlO.Callout openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Drop, value, diffs, objName, "Drop");
  }
  
  private static void SetDrop(DXVmlO.Callout openXmlElement, String? value)
  {
    openXmlElement.Drop = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  private static String? GetDistance(DXVmlO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Distance);
  }
  
  private static bool CmpDistance(DXVmlO.Callout openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Distance, value, diffs, objName, "Distance");
  }
  
  private static void SetDistance(DXVmlO.Callout openXmlElement, String? value)
  {
    openXmlElement.Distance = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  private static Boolean? GetLengthSpecified(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.LengthSpecified?.Value;
  }
  
  private static bool CmpLengthSpecified(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LengthSpecified?.Value == value) return true;
    diffs?.Add(objName, "LengthSpecified", openXmlElement?.LengthSpecified?.Value, value);
    return false;
  }
  
  private static void SetLengthSpecified(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LengthSpecified = value;
    else
      openXmlElement.LengthSpecified = null;
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  private static String? GetLength(DXVmlO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Length);
  }
  
  private static bool CmpLength(DXVmlO.Callout openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Length, value, diffs, objName, "Length");
  }
  
  private static void SetLength(DXVmlO.Callout openXmlElement, String? value)
  {
    openXmlElement.Length = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  private static Boolean? GetAccentBar(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.AccentBar?.Value;
  }
  
  private static bool CmpAccentBar(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AccentBar?.Value == value) return true;
    diffs?.Add(objName, "AccentBar", openXmlElement?.AccentBar?.Value, value);
    return false;
  }
  
  private static void SetAccentBar(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AccentBar = value;
    else
      openXmlElement.AccentBar = null;
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  private static Boolean? GetTextBorder(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.TextBorder?.Value;
  }
  
  private static bool CmpTextBorder(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TextBorder?.Value == value) return true;
    diffs?.Add(objName, "TextBorder", openXmlElement?.TextBorder?.Value, value);
    return false;
  }
  
  private static void SetTextBorder(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBorder = value;
    else
      openXmlElement.TextBorder = null;
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  private static Boolean? GetMinusX(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.MinusX?.Value;
  }
  
  private static bool CmpMinusX(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MinusX?.Value == value) return true;
    diffs?.Add(objName, "MinusX", openXmlElement?.MinusX?.Value, value);
    return false;
  }
  
  private static void SetMinusX(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusX = value;
    else
      openXmlElement.MinusX = null;
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  private static Boolean? GetMinusY(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.MinusY?.Value;
  }
  
  private static bool CmpMinusY(DXVmlO.Callout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MinusY?.Value == value) return true;
    diffs?.Add(objName, "MinusY", openXmlElement?.MinusY?.Value, value);
    return false;
  }
  
  private static void SetMinusY(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusY = value;
    else
      openXmlElement.MinusY = null;
  }
  
  public static DocumentModel.Vml.Callout? CreateModelElement(DXVmlO.Callout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Callout();
      value.Extension = GetExtension(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Gap = GetGap(openXmlElement);
      value.Angle = GetAngle(openXmlElement);
      value.DropAuto = GetDropAuto(openXmlElement);
      value.Drop = GetDrop(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.LengthSpecified = GetLengthSpecified(openXmlElement);
      value.Length = GetLength(openXmlElement);
      value.AccentBar = GetAccentBar(openXmlElement);
      value.TextBorder = GetTextBorder(openXmlElement);
      value.MinusX = GetMinusX(openXmlElement);
      value.MinusY = GetMinusY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Callout? openXmlElement, DMVml.Callout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpGap(openXmlElement, value.Gap, diffs, objName))
        ok = false;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName))
        ok = false;
      if (!CmpDropAuto(openXmlElement, value.DropAuto, diffs, objName))
        ok = false;
      if (!CmpDrop(openXmlElement, value.Drop, diffs, objName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName))
        ok = false;
      if (!CmpLengthSpecified(openXmlElement, value.LengthSpecified, diffs, objName))
        ok = false;
      if (!CmpLength(openXmlElement, value.Length, diffs, objName))
        ok = false;
      if (!CmpAccentBar(openXmlElement, value.AccentBar, diffs, objName))
        ok = false;
      if (!CmpTextBorder(openXmlElement, value.TextBorder, diffs, objName))
        ok = false;
      if (!CmpMinusX(openXmlElement, value.MinusX, diffs, objName))
        ok = false;
      if (!CmpMinusY(openXmlElement, value.MinusY, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Callout value)
    where OpenXmlElementType: DXVmlO.Callout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Callout openXmlElement, DMVml.Callout value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetOn(openXmlElement, value?.On);
    SetType(openXmlElement, value?.Type);
    SetGap(openXmlElement, value?.Gap);
    SetAngle(openXmlElement, value?.Angle);
    SetDropAuto(openXmlElement, value?.DropAuto);
    SetDrop(openXmlElement, value?.Drop);
    SetDistance(openXmlElement, value?.Distance);
    SetLengthSpecified(openXmlElement, value?.LengthSpecified);
    SetLength(openXmlElement, value?.Length);
    SetAccentBar(openXmlElement, value?.AccentBar);
    SetTextBorder(openXmlElement, value?.TextBorder);
    SetMinusX(openXmlElement, value?.MinusX);
    SetMinusY(openXmlElement, value?.MinusY);
  }
}

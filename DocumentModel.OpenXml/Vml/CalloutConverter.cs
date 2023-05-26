namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public static class CalloutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Callout openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.Callout openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  private static Boolean? GetOn(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  private static String? GetType(DXVO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXVO.Callout openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXVO.Callout openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  private static String? GetGap(DXVO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Gap);
  }
  
  private static bool CmpGap(DXVO.Callout openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Gap, value, diffs, objName, "Gap");
  }
  
  private static void SetGap(DXVO.Callout openXmlElement, String? value)
  {
    openXmlElement.Gap = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  private static DMV.AngleKind? GetAngle(DXVO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMV.AngleKind>(openXmlElement?.Angle?.Value);
  }
  
  private static bool CmpAngle(DXVO.Callout openXmlElement, DMV.AngleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMV.AngleKind>(openXmlElement?.Angle?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAngle(DXVO.Callout openXmlElement, DMV.AngleKind? value)
  {
    openXmlElement.Angle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMV.AngleKind>(value);
  }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  private static Boolean? GetDropAuto(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.DropAuto?.Value;
  }
  
  private static bool CmpDropAuto(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DropAuto?.Value == value) return true;
    diffs?.Add(objName, "DropAuto", openXmlElement?.DropAuto?.Value, value);
    return false;
  }
  
  private static void SetDropAuto(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DropAuto = value;
    else
      openXmlElement.DropAuto = null;
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  private static String? GetDrop(DXVO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Drop);
  }
  
  private static bool CmpDrop(DXVO.Callout openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Drop, value, diffs, objName, "Drop");
  }
  
  private static void SetDrop(DXVO.Callout openXmlElement, String? value)
  {
    openXmlElement.Drop = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  private static String? GetDistance(DXVO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Distance);
  }
  
  private static bool CmpDistance(DXVO.Callout openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Distance, value, diffs, objName, "Distance");
  }
  
  private static void SetDistance(DXVO.Callout openXmlElement, String? value)
  {
    openXmlElement.Distance = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  private static Boolean? GetLengthSpecified(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.LengthSpecified?.Value;
  }
  
  private static bool CmpLengthSpecified(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LengthSpecified?.Value == value) return true;
    diffs?.Add(objName, "LengthSpecified", openXmlElement?.LengthSpecified?.Value, value);
    return false;
  }
  
  private static void SetLengthSpecified(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LengthSpecified = value;
    else
      openXmlElement.LengthSpecified = null;
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  private static String? GetLength(DXVO.Callout openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Length);
  }
  
  private static bool CmpLength(DXVO.Callout openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Length, value, diffs, objName, "Length");
  }
  
  private static void SetLength(DXVO.Callout openXmlElement, String? value)
  {
    openXmlElement.Length = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  private static Boolean? GetAccentBar(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.AccentBar?.Value;
  }
  
  private static bool CmpAccentBar(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AccentBar?.Value == value) return true;
    diffs?.Add(objName, "AccentBar", openXmlElement?.AccentBar?.Value, value);
    return false;
  }
  
  private static void SetAccentBar(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AccentBar = value;
    else
      openXmlElement.AccentBar = null;
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  private static Boolean? GetTextBorder(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.TextBorder?.Value;
  }
  
  private static bool CmpTextBorder(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.TextBorder?.Value == value) return true;
    diffs?.Add(objName, "TextBorder", openXmlElement?.TextBorder?.Value, value);
    return false;
  }
  
  private static void SetTextBorder(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBorder = value;
    else
      openXmlElement.TextBorder = null;
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  private static Boolean? GetMinusX(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.MinusX?.Value;
  }
  
  private static bool CmpMinusX(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.MinusX?.Value == value) return true;
    diffs?.Add(objName, "MinusX", openXmlElement?.MinusX?.Value, value);
    return false;
  }
  
  private static void SetMinusX(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusX = value;
    else
      openXmlElement.MinusX = null;
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  private static Boolean? GetMinusY(DXVO.Callout openXmlElement)
  {
    return openXmlElement?.MinusY?.Value;
  }
  
  private static bool CmpMinusY(DXVO.Callout openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.MinusY?.Value == value) return true;
    diffs?.Add(objName, "MinusY", openXmlElement?.MinusY?.Value, value);
    return false;
  }
  
  private static void SetMinusY(DXVO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusY = value;
    else
      openXmlElement.MinusY = null;
  }
  
  public static DocumentModel.Vml.Callout? CreateModelElement(DXVO.Callout? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Callout? openXmlElement, DMV.Callout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpGap(openXmlElement, value.Gap, diffs, objName, propName))
        ok = false;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName, propName))
        ok = false;
      if (!CmpDropAuto(openXmlElement, value.DropAuto, diffs, objName, propName))
        ok = false;
      if (!CmpDrop(openXmlElement, value.Drop, diffs, objName, propName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName, propName))
        ok = false;
      if (!CmpLengthSpecified(openXmlElement, value.LengthSpecified, diffs, objName, propName))
        ok = false;
      if (!CmpLength(openXmlElement, value.Length, diffs, objName, propName))
        ok = false;
      if (!CmpAccentBar(openXmlElement, value.AccentBar, diffs, objName, propName))
        ok = false;
      if (!CmpTextBorder(openXmlElement, value.TextBorder, diffs, objName, propName))
        ok = false;
      if (!CmpMinusX(openXmlElement, value.MinusX, diffs, objName, propName))
        ok = false;
      if (!CmpMinusY(openXmlElement, value.MinusY, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Callout value)
    where OpenXmlElementType: DXVO.Callout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Callout openXmlElement, DMV.Callout value)
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

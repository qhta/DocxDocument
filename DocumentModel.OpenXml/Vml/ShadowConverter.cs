namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class ShadowConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  private static Boolean? GetOn(DXV.Shadow openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXV.Shadow openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXV.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  private static DMV.ShadowKind? GetType(DXV.Shadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMV.ShadowKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXV.Shadow openXmlElement, DMV.ShadowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMV.ShadowKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXV.Shadow openXmlElement, DMV.ShadowKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMV.ShadowKind>(value);
  }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  private static Boolean? GetObscured(DXV.Shadow openXmlElement)
  {
    return openXmlElement?.Obscured?.Value;
  }
  
  private static bool CmpObscured(DXV.Shadow openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Obscured?.Value == value) return true;
    diffs?.Add(objName, "Obscured", openXmlElement?.Obscured?.Value, value);
    return false;
  }
  
  private static void SetObscured(DXV.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Obscured = value;
    else
      openXmlElement.Obscured = null;
  }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  private static String? GetColor(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  private static String? GetOpacity(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  private static String? GetOffset(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Offset);
  }
  
  private static bool CmpOffset(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Offset, value, diffs, objName, "Offset");
  }
  
  private static void SetOffset(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Offset = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  private static String? GetColor2(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  private static String? GetOffset2(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Offset2);
  }
  
  private static bool CmpOffset2(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Offset2, value, diffs, objName, "Offset2");
  }
  
  private static void SetOffset2(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Offset2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  private static String? GetOrigin(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Origin);
  }
  
  private static bool CmpOrigin(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Origin, value, diffs, objName, "Origin");
  }
  
  private static void SetOrigin(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Origin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXV.Shadow openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Matrix);
  }
  
  private static bool CmpMatrix(DXV.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Matrix, value, diffs, objName, "Matrix");
  }
  
  private static void SetMatrix(DXV.Shadow openXmlElement, String? value)
  {
    openXmlElement.Matrix = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Shadow? CreateModelElement(DXV.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Shadow();
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Obscured = GetObscured(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
      value.Offset2 = GetOffset2(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Shadow? openXmlElement, DMV.Shadow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpObscured(openXmlElement, value.Obscured, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpOpacity(openXmlElement, value.Opacity, diffs, objName))
        ok = false;
      if (!CmpOffset(openXmlElement, value.Offset, diffs, objName))
        ok = false;
      if (!CmpColor2(openXmlElement, value.Color2, diffs, objName))
        ok = false;
      if (!CmpOffset2(openXmlElement, value.Offset2, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Shadow value)
    where OpenXmlElementType: DXV.Shadow, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Shadow openXmlElement, DMV.Shadow value)
  {
    SetId(openXmlElement, value?.Id);
    SetOn(openXmlElement, value?.On);
    SetType(openXmlElement, value?.Type);
    SetObscured(openXmlElement, value?.Obscured);
    SetColor(openXmlElement, value?.Color);
    SetOpacity(openXmlElement, value?.Opacity);
    SetOffset(openXmlElement, value?.Offset);
    SetColor2(openXmlElement, value?.Color2);
    SetOffset2(openXmlElement, value?.Offset2);
    SetOrigin(openXmlElement, value?.Origin);
    SetMatrix(openXmlElement, value?.Matrix);
  }
}

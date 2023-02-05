namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class ShadowConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVml.Shadow openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVml.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  private static DMVml.ShadowKind? GetType(DXVml.Shadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMVml.ShadowKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVml.Shadow openXmlElement, DMVml.ShadowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMVml.ShadowKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXVml.Shadow openXmlElement, DMVml.ShadowKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMVml.ShadowKind>(value);
  }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  private static Boolean? GetObscured(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Obscured?.Value;
  }
  
  private static bool CmpObscured(DXVml.Shadow openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Obscured?.Value == value) return true;
    diffs?.Add(objName, "Obscured", openXmlElement?.Obscured?.Value, value);
    return false;
  }
  
  private static void SetObscured(DXVml.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Obscured = value;
    else
      openXmlElement.Obscured = null;
  }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  private static String? GetColor(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static bool CmpColor(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color?.Value == value) return true;
    diffs?.Add(objName, "Color", openXmlElement?.Color?.Value, value);
    return false;
  }
  
  private static void SetColor(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  private static String? GetOpacity(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static bool CmpOpacity(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Opacity?.Value == value) return true;
    diffs?.Add(objName, "Opacity", openXmlElement?.Opacity?.Value, value);
    return false;
  }
  
  private static void SetOpacity(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  private static String? GetOffset(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Offset?.Value;
  }
  
  private static bool CmpOffset(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Offset?.Value == value) return true;
    diffs?.Add(objName, "Offset", openXmlElement?.Offset?.Value, value);
    return false;
  }
  
  private static void SetOffset(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Offset = new StringValue { Value = value };
    else
      openXmlElement.Offset = null;
  }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  private static String? GetColor2(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static bool CmpColor2(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color2?.Value == value) return true;
    diffs?.Add(objName, "Color2", openXmlElement?.Color2?.Value, value);
    return false;
  }
  
  private static void SetColor2(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  private static String? GetOffset2(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Offset2?.Value;
  }
  
  private static bool CmpOffset2(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Offset2?.Value == value) return true;
    diffs?.Add(objName, "Offset2", openXmlElement?.Offset2?.Value, value);
    return false;
  }
  
  private static void SetOffset2(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Offset2 = new StringValue { Value = value };
    else
      openXmlElement.Offset2 = null;
  }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  private static String? GetOrigin(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  private static bool CmpOrigin(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Origin?.Value == value) return true;
    diffs?.Add(objName, "Origin", openXmlElement?.Origin?.Value, value);
    return false;
  }
  
  private static void SetOrigin(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Origin = new StringValue { Value = value };
    else
      openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }
  
  private static bool CmpMatrix(DXVml.Shadow openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Matrix?.Value == value) return true;
    diffs?.Add(objName, "Matrix", openXmlElement?.Matrix?.Value, value);
    return false;
  }
  
  private static void SetMatrix(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Matrix = new StringValue { Value = value };
    else
      openXmlElement.Matrix = null;
  }
  
  public static DMVml.Shadow? CreateModelElement(DXVml.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Shadow();
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
  
  public static bool CompareModelElement(DXVml.Shadow? openXmlElement, DMVml.Shadow? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Shadow? value)
    where OpenXmlElementType: DXVml.Shadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}

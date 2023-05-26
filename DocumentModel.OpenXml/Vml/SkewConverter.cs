namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Skew Transform.
/// </summary>
public static class SkewConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Skew openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Skew openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.Skew openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  private static String? GetId(DXVO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVO.Skew openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXVO.Skew openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  private static Boolean? GetOn(DXVO.Skew openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVO.Skew openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVO.Skew openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  private static String? GetOffset(DXVO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Offset);
  }
  
  private static bool CmpOffset(DXVO.Skew openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Offset, value, diffs, objName, "Offset");
  }
  
  private static void SetOffset(DXVO.Skew openXmlElement, String? value)
  {
    openXmlElement.Offset = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  private static String? GetOrigin(DXVO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Origin);
  }
  
  private static bool CmpOrigin(DXVO.Skew openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Origin, value, diffs, objName, "Origin");
  }
  
  private static void SetOrigin(DXVO.Skew openXmlElement, String? value)
  {
    openXmlElement.Origin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXVO.Skew openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Matrix);
  }
  
  private static bool CmpMatrix(DXVO.Skew openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Matrix, value, diffs, objName, "Matrix");
  }
  
  private static void SetMatrix(DXVO.Skew openXmlElement, String? value)
  {
    openXmlElement.Matrix = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Skew? CreateModelElement(DXVO.Skew? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Skew? openXmlElement, DMV.Skew? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName, propName))
        ok = false;
      if (!CmpOffset(openXmlElement, value.Offset, diffs, objName, propName))
        ok = false;
      if (!CmpOrigin(openXmlElement, value.Origin, diffs, objName, propName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Skew value)
    where OpenXmlElementType: DXVO.Skew, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Skew openXmlElement, DMV.Skew value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetId(openXmlElement, value?.Id);
    SetOn(openXmlElement, value?.On);
    SetOffset(openXmlElement, value?.Offset);
    SetOrigin(openXmlElement, value?.Origin);
    SetMatrix(openXmlElement, value?.Matrix);
  }
}

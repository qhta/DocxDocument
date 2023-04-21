namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.TextPath openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.TextPath openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXV.TextPath openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXV.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXV.TextPath openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetOn(DXV.TextPath openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXV.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXV.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  private static Boolean? GetFitShape(DXV.TextPath openXmlElement)
  {
    return openXmlElement?.FitShape?.Value;
  }
  
  private static bool CmpFitShape(DXV.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FitShape?.Value == value) return true;
    diffs?.Add(objName, "FitShape", openXmlElement?.FitShape?.Value, value);
    return false;
  }
  
  private static void SetFitShape(DXV.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitShape = value;
    else
      openXmlElement.FitShape = null;
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  private static Boolean? GetFitPath(DXV.TextPath openXmlElement)
  {
    return openXmlElement?.FitPath?.Value;
  }
  
  private static bool CmpFitPath(DXV.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FitPath?.Value == value) return true;
    diffs?.Add(objName, "FitPath", openXmlElement?.FitPath?.Value, value);
    return false;
  }
  
  private static void SetFitPath(DXV.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitPath = value;
    else
      openXmlElement.FitPath = null;
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  private static Boolean? GetTrim(DXV.TextPath openXmlElement)
  {
    return openXmlElement?.Trim?.Value;
  }
  
  private static bool CmpTrim(DXV.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Trim?.Value == value) return true;
    diffs?.Add(objName, "Trim", openXmlElement?.Trim?.Value, value);
    return false;
  }
  
  private static void SetTrim(DXV.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Trim = value;
    else
      openXmlElement.Trim = null;
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  private static Boolean? GetXScale(DXV.TextPath openXmlElement)
  {
    return openXmlElement?.XScale?.Value;
  }
  
  private static bool CmpXScale(DXV.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.XScale?.Value == value) return true;
    diffs?.Add(objName, "XScale", openXmlElement?.XScale?.Value, value);
    return false;
  }
  
  private static void SetXScale(DXV.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.XScale = value;
    else
      openXmlElement.XScale = null;
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  private static String? GetString(DXV.TextPath openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.String);
  }
  
  private static bool CmpString(DXV.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.String, value, diffs, objName, "String");
  }
  
  private static void SetString(DXV.TextPath openXmlElement, String? value)
  {
    openXmlElement.String = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.TextPath? CreateModelElement(DXV.TextPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextPath();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.FitShape = GetFitShape(openXmlElement);
      value.FitPath = GetFitPath(openXmlElement);
      value.Trim = GetTrim(openXmlElement);
      value.XScale = GetXScale(openXmlElement);
      value.String = GetString(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.TextPath? openXmlElement, DMV.TextPath? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpFitShape(openXmlElement, value.FitShape, diffs, objName))
        ok = false;
      if (!CmpFitPath(openXmlElement, value.FitPath, diffs, objName))
        ok = false;
      if (!CmpTrim(openXmlElement, value.Trim, diffs, objName))
        ok = false;
      if (!CmpXScale(openXmlElement, value.XScale, diffs, objName))
        ok = false;
      if (!CmpString(openXmlElement, value.String, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.TextPath value)
    where OpenXmlElementType: DXV.TextPath, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.TextPath openXmlElement, DMV.TextPath value)
  {
    SetId(openXmlElement, value?.Id);
    SetStyle(openXmlElement, value?.Style);
    SetOn(openXmlElement, value?.On);
    SetFitShape(openXmlElement, value?.FitShape);
    SetFitPath(openXmlElement, value?.FitPath);
    SetTrim(openXmlElement, value?.Trim);
    SetXScale(openXmlElement, value?.XScale);
    SetString(openXmlElement, value?.String);
  }
}

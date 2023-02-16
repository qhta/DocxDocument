namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVml.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Style?.Value == value) return true;
    diffs?.Add(objName, "Style", openXmlElement?.Style?.Value, value);
    return false;
  }
  
  private static void SetStyle(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVml.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  private static Boolean? GetFitShape(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.FitShape?.Value;
  }
  
  private static bool CmpFitShape(DXVml.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FitShape?.Value == value) return true;
    diffs?.Add(objName, "FitShape", openXmlElement?.FitShape?.Value, value);
    return false;
  }
  
  private static void SetFitShape(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitShape = value;
    else
      openXmlElement.FitShape = null;
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  private static Boolean? GetFitPath(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.FitPath?.Value;
  }
  
  private static bool CmpFitPath(DXVml.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FitPath?.Value == value) return true;
    diffs?.Add(objName, "FitPath", openXmlElement?.FitPath?.Value, value);
    return false;
  }
  
  private static void SetFitPath(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitPath = value;
    else
      openXmlElement.FitPath = null;
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  private static Boolean? GetTrim(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Trim?.Value;
  }
  
  private static bool CmpTrim(DXVml.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Trim?.Value == value) return true;
    diffs?.Add(objName, "Trim", openXmlElement?.Trim?.Value, value);
    return false;
  }
  
  private static void SetTrim(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Trim = value;
    else
      openXmlElement.Trim = null;
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  private static Boolean? GetXScale(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.XScale?.Value;
  }
  
  private static bool CmpXScale(DXVml.TextPath openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.XScale?.Value == value) return true;
    diffs?.Add(objName, "XScale", openXmlElement?.XScale?.Value, value);
    return false;
  }
  
  private static void SetXScale(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.XScale = value;
    else
      openXmlElement.XScale = null;
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  private static String? GetString(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.String?.Value;
  }
  
  private static bool CmpString(DXVml.TextPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.String?.Value == value) return true;
    diffs?.Add(objName, "String", openXmlElement?.String?.Value, value);
    return false;
  }
  
  private static void SetString(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.String = new StringValue { Value = value };
    else
      openXmlElement.String = null;
  }
  
  public static DocumentModel.Vml.TextPath? CreateModelElement(DXVml.TextPath? openXmlElement)
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
  
  public static bool CompareModelElement(DXVml.TextPath? openXmlElement, DMVml.TextPath? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.TextPath? value)
    where OpenXmlElementType: DXVml.TextPath, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetOn(openXmlElement, value?.On);
      SetFitShape(openXmlElement, value?.FitShape);
      SetFitPath(openXmlElement, value?.FitPath);
      SetTrim(openXmlElement, value?.Trim);
      SetXScale(openXmlElement, value?.XScale);
      SetString(openXmlElement, value?.String);
      return openXmlElement;
    }
    return default;
  }
}

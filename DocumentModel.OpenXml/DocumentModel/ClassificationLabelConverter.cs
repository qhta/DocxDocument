namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabel Class.
/// </summary>
public static class ClassificationLabelConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO21MLMD.ClassificationLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO21MLMD.ClassificationLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// setDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetSetDate(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SetDate);
  }
  
  private static bool CmpSetDate(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SetDate, value, diffs, objName, "SetDate");
  }
  
  private static void SetSetDate(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.SetDate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetMethod(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Method);
  }
  
  private static bool CmpMethod(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Method, value, diffs, objName, "Method");
  }
  
  private static void SetMethod(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Method = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetName(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetSiteId(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SiteId);
  }
  
  private static bool CmpSiteId(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SiteId, value, diffs, objName, "SiteId");
  }
  
  private static void SetSiteId(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.SiteId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetActionId(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ActionId);
  }
  
  private static bool CmpActionId(DXO21MLMD.ClassificationLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ActionId, value, diffs, objName, "ActionId");
  }
  
  private static void SetActionId(DXO21MLMD.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.ActionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetContentBits(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.ContentBits?.Value;
  }
  
  private static bool CmpContentBits(DXO21MLMD.ClassificationLabel openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentBits?.Value == value) return true;
    diffs?.Add(objName, "ContentBits", openXmlElement?.ContentBits?.Value, value);
    return false;
  }
  
  private static void SetContentBits(DXO21MLMD.ClassificationLabel openXmlElement, UInt32? value)
  {
    openXmlElement.ContentBits = value;
  }
  
  /// <summary>
  /// removed, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetRemoved(DXO21MLMD.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Removed?.Value;
  }
  
  private static bool CmpRemoved(DXO21MLMD.ClassificationLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Removed?.Value == value) return true;
    diffs?.Add(objName, "Removed", openXmlElement?.Removed?.Value, value);
    return false;
  }
  
  private static void SetRemoved(DXO21MLMD.ClassificationLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Removed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Removed = null;
  }
  
  public static DocumentModel.ClassificationLabel? CreateModelElement(DXO21MLMD.ClassificationLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationLabel();
      value.Id = GetId(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.SetDate = GetSetDate(openXmlElement);
      value.Method = GetMethod(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.SiteId = GetSiteId(openXmlElement);
      value.ActionId = GetActionId(openXmlElement);
      value.ContentBits = GetContentBits(openXmlElement);
      value.Removed = GetRemoved(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21MLMD.ClassificationLabel? openXmlElement, DM.ClassificationLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName, propName))
        ok = false;
      if (!CmpSetDate(openXmlElement, value.SetDate, diffs, objName, propName))
        ok = false;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName, propName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpSiteId(openXmlElement, value.SiteId, diffs, objName, propName))
        ok = false;
      if (!CmpActionId(openXmlElement, value.ActionId, diffs, objName, propName))
        ok = false;
      if (!CmpContentBits(openXmlElement, value.ContentBits, diffs, objName, propName))
        ok = false;
      if (!CmpRemoved(openXmlElement, value.Removed, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationLabel value)
    where OpenXmlElementType: DXO21MLMD.ClassificationLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21MLMD.ClassificationLabel openXmlElement, DM.ClassificationLabel value)
  {
    SetId(openXmlElement, value?.Id);
    SetEnabled(openXmlElement, value?.Enabled);
    SetSetDate(openXmlElement, value?.SetDate);
    SetMethod(openXmlElement, value?.Method);
    SetName(openXmlElement, value?.Name);
    SetSiteId(openXmlElement, value?.SiteId);
    SetActionId(openXmlElement, value?.ActionId);
    SetContentBits(openXmlElement, value?.ContentBits);
    SetRemoved(openXmlElement, value?.Removed);
  }
}

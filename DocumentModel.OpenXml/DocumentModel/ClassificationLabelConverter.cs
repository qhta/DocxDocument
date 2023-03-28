namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabel Class converter from/to OpenXml.
///</summary>
public static class ClassificationLabelConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// setDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetSetDate(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SetDate);
  }
  
  private static bool CmpSetDate(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SetDate, value, diffs, objName, "SetDate");
  }
  
  private static void SetSetDate(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.SetDate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Method);
  }
  
  private static bool CmpMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Method, value, diffs, objName, "Method");
  }
  
  private static void SetMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Method = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SiteId);
  }
  
  private static bool CmpSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SiteId, value, diffs, objName, "SiteId");
  }
  
  private static void SetSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.SiteId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ActionId);
  }
  
  private static bool CmpActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ActionId, value, diffs, objName, "ActionId");
  }
  
  private static void SetActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    openXmlElement.ActionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetContentBits(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.ContentBits?.Value;
  }
  
  private static bool CmpContentBits(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentBits?.Value == value) return true;
    diffs?.Add(objName, "ContentBits", openXmlElement?.ContentBits?.Value, value);
    return false;
  }
  
  private static void SetContentBits(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, UInt32? value)
  {
    openXmlElement.ContentBits = value;
  }
  
  /// <summary>
  /// removed, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetRemoved(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Removed?.Value;
  }
  
  private static bool CmpRemoved(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Removed?.Value == value) return true;
    diffs?.Add(objName, "Removed", openXmlElement?.Removed?.Value, value);
    return false;
  }
  
  private static void SetRemoved(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Removed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Removed = null;
  }
  
  public static DocumentModel.ClassificationLabel? CreateModelElement(DXO2021MipLabelMeta.ClassificationLabel? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2021MipLabelMeta.ClassificationLabel? openXmlElement, DM.ClassificationLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpSetDate(openXmlElement, value.SetDate, diffs, objName))
        ok = false;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpSiteId(openXmlElement, value.SiteId, diffs, objName))
        ok = false;
      if (!CmpActionId(openXmlElement, value.ActionId, diffs, objName))
        ok = false;
      if (!CmpContentBits(openXmlElement, value.ContentBits, diffs, objName))
        ok = false;
      if (!CmpRemoved(openXmlElement, value.Removed, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationLabel value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, DM.ClassificationLabel value)
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

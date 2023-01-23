namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabel Class.
/// </summary>
public static class ClassificationLabelConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
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
    return openXmlElement?.Enabled?.Value == value;
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
    return openXmlElement?.SetDate?.Value;
  }
  
  private static bool CmpSetDate(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SetDate?.Value == value;
  }
  
  private static void SetSetDate(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SetDate = new StringValue { Value = value };
    else
      openXmlElement.SetDate = null;
  }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Method?.Value;
  }
  
  private static bool CmpMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Method?.Value == value;
  }
  
  private static void SetMethod(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Method = new StringValue { Value = value };
    else
      openXmlElement.Method = null;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.SiteId?.Value;
  }
  
  private static bool CmpSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SiteId?.Value == value;
  }
  
  private static void SetSiteId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SiteId = new StringValue { Value = value };
    else
      openXmlElement.SiteId = null;
  }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement?.ActionId?.Value;
  }
  
  private static bool CmpActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ActionId?.Value == value;
  }
  
  private static void SetActionId(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ActionId = new StringValue { Value = value };
    else
      openXmlElement.ActionId = null;
  }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetContentBits(DXO2021MipLabelMeta.ClassificationLabel openXmlElement)
  {
    return openXmlElement.ContentBits?.Value;
  }
  
  private static bool CmpContentBits(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ContentBits?.Value == value;
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
    return openXmlElement?.Removed?.Value == value;
  }
  
  private static void SetRemoved(DXO2021MipLabelMeta.ClassificationLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Removed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Removed = null;
  }
  
  public static DM.ClassificationLabel? CreateModelElement(DXO2021MipLabelMeta.ClassificationLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ClassificationLabel();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationLabel? value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetEnabled(openXmlElement, value?.Enabled);
      SetSetDate(openXmlElement, value?.SetDate);
      SetMethod(openXmlElement, value?.Method);
      SetName(openXmlElement, value?.Name);
      SetSiteId(openXmlElement, value?.SiteId);
      SetActionId(openXmlElement, value?.ActionId);
      SetContentBits(openXmlElement, value?.ContentBits);
      SetRemoved(openXmlElement, value?.Removed);
      return openXmlElement;
    }
    return default;
  }
}

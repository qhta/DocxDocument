namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  private static String? GetId(DXDC.ExternalData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXDC.ExternalData openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXDC.ExternalData openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  private static Boolean? GetAutoUpdate(DXDC.ExternalData openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.AutoUpdate>() != null;
  }
  
  private static bool CmpAutoUpdate(DXDC.ExternalData openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.AutoUpdate>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.AutoUpdate", val, value);
    return false;
  }
  
  private static void SetAutoUpdate(DXDC.ExternalData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.AutoUpdate>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.AutoUpdate();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.ExternalData? CreateModelElement(DXDC.ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ExternalData? openXmlElement, DMDC.ExternalData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpAutoUpdate(openXmlElement, value.AutoUpdate, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ExternalData value)
    where OpenXmlElementType: DXDC.ExternalData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ExternalData openXmlElement, DMDC.ExternalData value)
  {
    SetId(openXmlElement, value?.Id);
    SetAutoUpdate(openXmlElement, value?.AutoUpdate);
  }
}

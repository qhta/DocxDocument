namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetId(DXO16DCD.ExternalData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO16DCD.ExternalData openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO16DCD.ExternalData openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetAutoUpdate(DXO16DCD.ExternalData openXmlElement)
  {
    return openXmlElement?.AutoUpdate?.Value;
  }
  
  private static bool CmpAutoUpdate(DXO16DCD.ExternalData openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AutoUpdate?.Value == value) return true;
    diffs?.Add(objName, "AutoUpdate", openXmlElement?.AutoUpdate?.Value, value);
    return false;
  }
  
  private static void SetAutoUpdate(DXO16DCD.ExternalData openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoUpdate = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AutoUpdate = null;
  }
  
  public static DMDCDs.ExternalData? CreateModelElement(DXO16DCD.ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ExternalData? openXmlElement, DMDCDs.ExternalData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ExternalData value)
    where OpenXmlElementType: DXO16DCD.ExternalData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ExternalData openXmlElement, DMDCDs.ExternalData value)
  {
    SetId(openXmlElement, value?.Id);
    SetAutoUpdate(openXmlElement, value?.AutoUpdate);
  }
}

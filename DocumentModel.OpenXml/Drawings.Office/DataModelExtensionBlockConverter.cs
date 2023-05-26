namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public static class DataModelExtensionBlockConverter
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetRelId(DXOD.DataModelExtensionBlock openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelId);
  }
  
  private static bool CmpRelId(DXOD.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelId, value, diffs, objName, "RelId");
  }
  
  private static void SetRelId(DXOD.DataModelExtensionBlock openXmlElement, String? value)
  {
    openXmlElement.RelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetMinVer(DXOD.DataModelExtensionBlock openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVer);
  }
  
  private static bool CmpMinVer(DXOD.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVer, value, diffs, objName, "MinVer");
  }
  
  private static void SetMinVer(DXOD.DataModelExtensionBlock openXmlElement, String? value)
  {
    openXmlElement.MinVer = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Office.DataModelExtensionBlock? CreateModelElement(DXOD.DataModelExtensionBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.DataModelExtensionBlock();
      value.RelId = GetRelId(openXmlElement);
      value.MinVer = GetMinVer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.DataModelExtensionBlock? openXmlElement, DMDO.DataModelExtensionBlock? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelId(openXmlElement, value.RelId, diffs, objName, propName))
        ok = false;
      if (!CmpMinVer(openXmlElement, value.MinVer, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.DataModelExtensionBlock value)
    where OpenXmlElementType: DXOD.DataModelExtensionBlock, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.DataModelExtensionBlock openXmlElement, DMDO.DataModelExtensionBlock value)
  {
    SetRelId(openXmlElement, value?.RelId);
    SetMinVer(openXmlElement, value?.MinVer);
  }
}

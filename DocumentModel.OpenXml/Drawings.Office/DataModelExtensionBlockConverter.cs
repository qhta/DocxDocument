namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the DataModelExtensionBlock Class converter from/to OpenXml.
///</summary>
public static class DataModelExtensionBlockConverter
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetRelId(DXODraw.DataModelExtensionBlock openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelId);
  }
  
  private static bool CmpRelId(DXODraw.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelId, value, diffs, objName, "RelId");
  }
  
  private static void SetRelId(DXODraw.DataModelExtensionBlock openXmlElement, String? value)
  {
    openXmlElement.RelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetMinVer(DXODraw.DataModelExtensionBlock openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVer);
  }
  
  private static bool CmpMinVer(DXODraw.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVer, value, diffs, objName, "MinVer");
  }
  
  private static void SetMinVer(DXODraw.DataModelExtensionBlock openXmlElement, String? value)
  {
    openXmlElement.MinVer = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Office.DataModelExtensionBlock? CreateModelElement(DXODraw.DataModelExtensionBlock? openXmlElement)
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
  
  public static bool CompareModelElement(DXODraw.DataModelExtensionBlock? openXmlElement, DMDrawsO.DataModelExtensionBlock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelId(openXmlElement, value.RelId, diffs, objName))
        ok = false;
      if (!CmpMinVer(openXmlElement, value.MinVer, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.DataModelExtensionBlock value)
    where OpenXmlElementType: DXODraw.DataModelExtensionBlock, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.DataModelExtensionBlock openXmlElement, DMDrawsO.DataModelExtensionBlock value)
  {
    SetRelId(openXmlElement, value?.RelId);
    SetMinVer(openXmlElement, value?.MinVer);
  }
}

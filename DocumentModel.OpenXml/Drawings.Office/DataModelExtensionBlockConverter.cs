namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public static class DataModelExtensionBlockConverter
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetRelId(DXODraw.DataModelExtensionBlock openXmlElement)
  {
    return openXmlElement?.RelId?.Value;
  }
  
  private static bool CmpRelId(DXODraw.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelId?.Value == value;
  }
  
  private static void SetRelId(DXODraw.DataModelExtensionBlock openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelId = new StringValue { Value = value };
    else
      openXmlElement.RelId = null;
  }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetMinVer(DXODraw.DataModelExtensionBlock openXmlElement)
  {
    return openXmlElement?.MinVer?.Value;
  }
  
  private static bool CmpMinVer(DXODraw.DataModelExtensionBlock openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MinVer?.Value == value;
  }
  
  private static void SetMinVer(DXODraw.DataModelExtensionBlock openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinVer = new StringValue { Value = value };
    else
      openXmlElement.MinVer = null;
  }
  
  public static DMDrawsO.DataModelExtensionBlock? CreateModelElement(DXODraw.DataModelExtensionBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.DataModelExtensionBlock();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.DataModelExtensionBlock? value)
    where OpenXmlElementType: DXODraw.DataModelExtensionBlock, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelId(openXmlElement, value?.RelId);
      SetMinVer(openXmlElement, value?.MinVer);
      return openXmlElement;
    }
    return default;
  }
}

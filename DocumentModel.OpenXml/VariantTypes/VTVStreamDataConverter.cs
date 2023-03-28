namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
/// Binary Versioned Stream converter from/to OpenXml.
///</summary>
public static class VTVStreamDataConverter
{
  /// <summary>
  /// VSTREAM Version Attribute
  /// </summary>
  private static String? GetVersion(DXVT.VTVStreamData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Version);
  }
  
  private static bool CmpVersion(DXVT.VTVStreamData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Version, value, diffs, objName, "Version");
  }
  
  private static void SetVersion(DXVT.VTVStreamData openXmlElement, String? value)
  {
    openXmlElement.Version = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.VariantTypes.VTVStreamData? CreateModelElement(DXVT.VTVStreamData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.VariantTypes.VTVStreamData();
      value.Version = GetVersion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVT.VTVStreamData? openXmlElement, DMVT.VTVStreamData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVersion(openXmlElement, value.Version, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVT.VTVStreamData value)
    where OpenXmlElementType: DXVT.VTVStreamData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVT.VTVStreamData openXmlElement, DMVT.VTVStreamData value)
  {
    SetVersion(openXmlElement, value?.Version);
  }
}

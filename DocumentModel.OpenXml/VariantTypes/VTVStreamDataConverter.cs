namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
/// Binary Versioned Stream.
/// </summary>
public static class VTVStreamDataConverter
{
  /// <summary>
  /// VSTREAM Version Attribute
  /// </summary>
  private static String? GetVersion(DXVT.VTVStreamData openXmlElement)
  {
    return openXmlElement?.Version?.Value;
  }
  
  private static bool CmpVersion(DXVT.VTVStreamData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Version?.Value == value) return true;
    diffs?.Add(objName, "Version", openXmlElement?.Version?.Value, value);
    return false;
  }
  
  private static void SetVersion(DXVT.VTVStreamData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Version = new StringValue { Value = value };
    else
      openXmlElement.Version = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVT.VTVStreamData? value)
    where OpenXmlElementType: DXVT.VTVStreamData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVersion(openXmlElement, value?.Version);
      return openXmlElement;
    }
    return default;
  }
}

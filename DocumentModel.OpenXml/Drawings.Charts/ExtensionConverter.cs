namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extension.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  private static String? GetUri(DXDC.Extension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Extension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Extension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.Charts.Extension? CreateModelElement(DXDC.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Extension? openXmlElement, DMDC.Extension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Extension value)
    where OpenXmlElementType: DXDC.Extension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Extension openXmlElement, DMDC.Extension value)
  {
    SetUri(openXmlElement, value?.Uri);
  }
}

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extension.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  private static String? GetUri(DXDrawCharts.Extension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.Extension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.Extension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMDrawsCharts.Extension? CreateModelElement(DXDrawCharts.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Extension? openXmlElement, DMDrawsCharts.Extension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Extension? value)
    where OpenXmlElementType: DXDrawCharts.Extension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}

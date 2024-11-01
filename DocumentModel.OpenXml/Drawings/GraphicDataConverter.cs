namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Object Data.
/// </summary>
public static class GraphicDataConverter
{
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  private static String? GetUri(DXD.GraphicData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.GraphicData openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.GraphicData openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.GraphicData? CreateModelElement(DXD.GraphicData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.GraphicData();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.GraphicData? openXmlElement, DMD.GraphicData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GraphicData value)
    where OpenXmlElementType: DXD.GraphicData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.GraphicData openXmlElement, DMD.GraphicData value)
  {
    SetUri(openXmlElement, value?.Uri);
  }
}

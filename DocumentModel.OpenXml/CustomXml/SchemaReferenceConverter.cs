namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public static class SchemaReferenceConverter
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  private static String? GetUri(DXCXDP.SchemaReference openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXCXDP.SchemaReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXCXDP.SchemaReference openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.CustomXml.SchemaReference? CreateModelElement(DXCXDP.SchemaReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaReference();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCXDP.SchemaReference? openXmlElement, DMCX.SchemaReference? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCX.SchemaReference value)
    where OpenXmlElementType: DXCXDP.SchemaReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCXDP.SchemaReference openXmlElement, DMCX.SchemaReference value)
  {
    SetUri(openXmlElement, value?.Uri);
  }
}

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public static class SchemaConverter
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  private static Uri? GetUri(DXCXSR.Schema openXmlElement)
  {
    if (openXmlElement?.Uri?.Value is not null)
      return new Uri(openXmlElement.Uri.Value);
    return null;
  }
  
  private static bool CmpUri(DXCXSR.Schema openXmlElement, Uri? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value?.ToString(), diffs, objName, "Uri");
  }
  
  private static void SetUri(DXCXSR.Schema openXmlElement, Uri? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value?.ToString());
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  private static String? GetManifestLocation(DXCXSR.Schema openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ManifestLocation);
  }
  
  private static bool CmpManifestLocation(DXCXSR.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ManifestLocation, value, diffs, objName, "ManifestLocation");
  }
  
  private static void SetManifestLocation(DXCXSR.Schema openXmlElement, String? value)
  {
    openXmlElement.ManifestLocation = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  private static String? GetSchemaLocation(DXCXSR.Schema openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SchemaLocation);
  }
  
  private static bool CmpSchemaLocation(DXCXSR.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SchemaLocation, value, diffs, objName, "SchemaLocation");
  }
  
  private static void SetSchemaLocation(DXCXSR.Schema openXmlElement, String? value)
  {
    openXmlElement.SchemaLocation = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.CustomXml.Schema? CreateModelElement(DXCXSR.Schema? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.Schema();
      value.Uri = GetUri(openXmlElement);
      value.ManifestLocation = GetManifestLocation(openXmlElement);
      value.SchemaLocation = GetSchemaLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCXSR.Schema? openXmlElement, DMCX.Schema? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpManifestLocation(openXmlElement, value.ManifestLocation, diffs, objName))
        ok = false;
      if (!CmpSchemaLocation(openXmlElement, value.SchemaLocation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXCXSR.Schema CreateOpenXmlElement(DMCX.Schema value)
  {
    var openXmlElement = new DXCXSR.Schema();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXCXSR.Schema openXmlElement, DMCX.Schema value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetManifestLocation(openXmlElement, value?.ManifestLocation);
    SetSchemaLocation(openXmlElement, value?.SchemaLocation);
    return true;
  }
}

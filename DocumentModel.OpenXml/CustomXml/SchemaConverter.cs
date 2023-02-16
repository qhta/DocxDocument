namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public static class SchemaConverter
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  private static String? GetUri(DXCustXmlSchRefs.Schema openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  private static String? GetManifestLocation(DXCustXmlSchRefs.Schema openXmlElement)
  {
    return openXmlElement?.ManifestLocation?.Value;
  }
  
  private static bool CmpManifestLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ManifestLocation?.Value == value) return true;
    diffs?.Add(objName, "ManifestLocation", openXmlElement?.ManifestLocation?.Value, value);
    return false;
  }
  
  private static void SetManifestLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ManifestLocation = new StringValue { Value = value };
    else
      openXmlElement.ManifestLocation = null;
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  private static String? GetSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement)
  {
    return openXmlElement?.SchemaLocation?.Value;
  }
  
  private static bool CmpSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SchemaLocation?.Value == value) return true;
    diffs?.Add(objName, "SchemaLocation", openXmlElement?.SchemaLocation?.Value, value);
    return false;
  }
  
  private static void SetSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SchemaLocation = new StringValue { Value = value };
    else
      openXmlElement.SchemaLocation = null;
  }
  
  public static DocumentModel.CustomXml.Schema? CreateModelElement(DXCustXmlSchRefs.Schema? openXmlElement)
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
  
  public static bool CompareModelElement(DXCustXmlSchRefs.Schema? openXmlElement, DMCustXml.Schema? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.Schema? value)
    where OpenXmlElementType: DXCustXmlSchRefs.Schema, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetManifestLocation(openXmlElement, value?.ManifestLocation);
      SetSchemaLocation(openXmlElement, value?.SchemaLocation);
      return openXmlElement;
    }
    return default;
  }
}

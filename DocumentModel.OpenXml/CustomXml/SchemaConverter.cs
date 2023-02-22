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
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  private static String? GetManifestLocation(DXCustXmlSchRefs.Schema openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ManifestLocation);
  }
  
  private static bool CmpManifestLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ManifestLocation, value, diffs, objName, "ManifestLocation");
  }
  
  private static void SetManifestLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    openXmlElement.ManifestLocation = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  private static String? GetSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SchemaLocation);
  }
  
  private static bool CmpSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SchemaLocation, value, diffs, objName, "SchemaLocation");
  }
  
  private static void SetSchemaLocation(DXCustXmlSchRefs.Schema openXmlElement, String? value)
  {
    openXmlElement.SchemaLocation = StringValueConverter.CreateStringValue(value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.Schema value)
    where OpenXmlElementType: DXCustXmlSchRefs.Schema, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCustXmlSchRefs.Schema openXmlElement, DMCustXml.Schema value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetManifestLocation(openXmlElement, value?.ManifestLocation);
    SetSchemaLocation(openXmlElement, value?.SchemaLocation);
    }
  }

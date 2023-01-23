namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public static class SchemaReferenceConverter
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  private static String? GetUri(DXCustXmlDataProps.SchemaReference openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXCustXmlDataProps.SchemaReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXCustXmlDataProps.SchemaReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMCustXml.SchemaReference? CreateModelElement(DXCustXmlDataProps.SchemaReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMCustXml.SchemaReference();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustXmlDataProps.SchemaReference? openXmlElement, DMCustXml.SchemaReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.SchemaReference? value)
    where OpenXmlElementType: DXCustXmlDataProps.SchemaReference, new()
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

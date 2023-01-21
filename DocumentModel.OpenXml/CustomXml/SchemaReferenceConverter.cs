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

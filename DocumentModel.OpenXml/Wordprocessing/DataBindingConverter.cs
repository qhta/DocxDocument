namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public static class DataBindingConverter
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public static String? GetPrefixMappings(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement)
  {
    return openXmlElement?.PrefixMappings?.Value;
  }
  
  public static void SetPrefixMappings(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PrefixMappings = new StringValue { Value = value };
      else
        openXmlElement.PrefixMappings = null;
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  public static String? GetXPath(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement)
  {
    return openXmlElement?.XPath?.Value;
  }
  
  public static void SetXPath(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XPath = new StringValue { Value = value };
      else
        openXmlElement.XPath = null;
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public static String? GetStoreItemId(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement)
  {
    return openXmlElement?.StoreItemId?.Value;
  }
  
  public static void SetStoreItemId(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StoreItemId = new StringValue { Value = value };
      else
        openXmlElement.StoreItemId = null;
  }
  
  public static DocumentModel.Wordprocessing.DataBinding? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DataBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DataBinding();
      value.PrefixMappings = GetPrefixMappings(openXmlElement);
      value.XPath = GetXPath(openXmlElement);
      value.StoreItemId = GetStoreItemId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DataBinding? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DataBinding, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPrefixMappings(openXmlElement, value?.PrefixMappings);
      SetXPath(openXmlElement, value?.XPath);
      SetStoreItemId(openXmlElement, value?.StoreItemId);
      return openXmlElement;
    }
    return default;
  }
}

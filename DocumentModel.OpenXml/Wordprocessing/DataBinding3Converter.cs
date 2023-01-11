namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public static class DataBinding3Converter
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public static String? GetPrefixMappings(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement)
  {
    return openXmlElement?.PrefixMappings?.Value;
  }
  
  public static void SetPrefixMappings(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement, String? value)
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
  public static String? GetXPath(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement)
  {
    return openXmlElement?.XPath?.Value;
  }
  
  public static void SetXPath(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement, String? value)
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
  public static String? GetStoreItemId(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement)
  {
    return openXmlElement?.StoreItemId?.Value;
  }
  
  public static void SetStoreItemId(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StoreItemId = new StringValue { Value = value };
      else
        openXmlElement.StoreItemId = null;
  }
  
  public static DocumentModel.Wordprocessing.DataBinding3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.DataBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DataBinding3();
      value.PrefixMappings = GetPrefixMappings(openXmlElement);
      value.XPath = GetXPath(openXmlElement);
      value.StoreItemId = GetStoreItemId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DataBinding3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.DataBinding, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

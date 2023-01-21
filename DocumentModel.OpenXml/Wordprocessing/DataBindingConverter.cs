namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public static class DataBindingConverter
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  private static String? GetPrefixMappings(DXW.DataBinding openXmlElement)
  {
    return openXmlElement?.PrefixMappings?.Value;
  }
  
  private static void SetPrefixMappings(DXW.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PrefixMappings = new StringValue { Value = value };
    else
      openXmlElement.PrefixMappings = null;
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  private static String? GetXPath(DXW.DataBinding openXmlElement)
  {
    return openXmlElement?.XPath?.Value;
  }
  
  private static void SetXPath(DXW.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.XPath = new StringValue { Value = value };
    else
      openXmlElement.XPath = null;
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  private static String? GetStoreItemId(DXW.DataBinding openXmlElement)
  {
    return openXmlElement?.StoreItemId?.Value;
  }
  
  private static void SetStoreItemId(DXW.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StoreItemId = new StringValue { Value = value };
    else
      openXmlElement.StoreItemId = null;
  }
  
  public static DMW.DataBinding? CreateModelElement(DXW.DataBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DataBinding();
      value.PrefixMappings = GetPrefixMappings(openXmlElement);
      value.XPath = GetXPath(openXmlElement);
      value.StoreItemId = GetStoreItemId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DataBinding? value)
    where OpenXmlElementType: DXW.DataBinding, new()
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

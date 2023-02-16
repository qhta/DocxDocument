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
  
  private static bool CmpPrefixMappings(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PrefixMappings?.Value == value) return true;
    diffs?.Add(objName, "PrefixMappings", openXmlElement?.PrefixMappings?.Value, value);
    return false;
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
  
  private static bool CmpXPath(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.XPath?.Value == value) return true;
    diffs?.Add(objName, "XPath", openXmlElement?.XPath?.Value, value);
    return false;
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
  
  private static bool CmpStoreItemId(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StoreItemId?.Value == value) return true;
    diffs?.Add(objName, "StoreItemId", openXmlElement?.StoreItemId?.Value, value);
    return false;
  }
  
  private static void SetStoreItemId(DXW.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StoreItemId = new StringValue { Value = value };
    else
      openXmlElement.StoreItemId = null;
  }
  
  public static DocumentModel.Wordprocessing.DataBinding? CreateModelElement(DXW.DataBinding? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.DataBinding? openXmlElement, DMW.DataBinding? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPrefixMappings(openXmlElement, value.PrefixMappings, diffs, objName))
        ok = false;
      if (!CmpXPath(openXmlElement, value.XPath, diffs, objName))
        ok = false;
      if (!CmpStoreItemId(openXmlElement, value.StoreItemId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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

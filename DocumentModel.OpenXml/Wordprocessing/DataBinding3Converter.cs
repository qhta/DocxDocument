namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public static class DataBinding3Converter
{
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  private static String? GetPrefixMappings(DXO2013W.DataBinding openXmlElement)
  {
    return openXmlElement?.PrefixMappings?.Value;
  }
  
  private static bool CmpPrefixMappings(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PrefixMappings?.Value == value) return true;
    diffs?.Add(objName, "PrefixMappings", openXmlElement?.PrefixMappings?.Value, value);
    return false;
  }
  
  private static void SetPrefixMappings(DXO2013W.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PrefixMappings = new StringValue { Value = value };
    else
      openXmlElement.PrefixMappings = null;
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  private static String? GetXPath(DXO2013W.DataBinding openXmlElement)
  {
    return openXmlElement?.XPath?.Value;
  }
  
  private static bool CmpXPath(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.XPath?.Value == value) return true;
    diffs?.Add(objName, "XPath", openXmlElement?.XPath?.Value, value);
    return false;
  }
  
  private static void SetXPath(DXO2013W.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.XPath = new StringValue { Value = value };
    else
      openXmlElement.XPath = null;
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  private static String? GetStoreItemId(DXO2013W.DataBinding openXmlElement)
  {
    return openXmlElement?.StoreItemId?.Value;
  }
  
  private static bool CmpStoreItemId(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StoreItemId?.Value == value) return true;
    diffs?.Add(objName, "StoreItemId", openXmlElement?.StoreItemId?.Value, value);
    return false;
  }
  
  private static void SetStoreItemId(DXO2013W.DataBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StoreItemId = new StringValue { Value = value };
    else
      openXmlElement.StoreItemId = null;
  }
  
  public static DocumentModel.Wordprocessing.DataBinding3? CreateModelElement(DXO2013W.DataBinding? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013W.DataBinding? openXmlElement, DMW.DataBinding3? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DataBinding3? value)
    where OpenXmlElementType: DXO2013W.DataBinding, new()
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

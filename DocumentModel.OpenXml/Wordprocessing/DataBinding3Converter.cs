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
    return StringValueConverter.GetValue(openXmlElement?.PrefixMappings);
  }
  
  private static bool CmpPrefixMappings(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PrefixMappings, value, diffs, objName, "PrefixMappings");
  }
  
  private static void SetPrefixMappings(DXO2013W.DataBinding openXmlElement, String? value)
  {
    openXmlElement.PrefixMappings = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  private static String? GetXPath(DXO2013W.DataBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XPath);
  }
  
  private static bool CmpXPath(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XPath, value, diffs, objName, "XPath");
  }
  
  private static void SetXPath(DXO2013W.DataBinding openXmlElement, String? value)
  {
    openXmlElement.XPath = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  private static String? GetStoreItemId(DXO2013W.DataBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StoreItemId);
  }
  
  private static bool CmpStoreItemId(DXO2013W.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StoreItemId, value, diffs, objName, "StoreItemId");
  }
  
  private static void SetStoreItemId(DXO2013W.DataBinding openXmlElement, String? value)
  {
    openXmlElement.StoreItemId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.DataBinding3? CreateModelElement(DXO2013W.DataBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DataBinding3();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DataBinding3 value)
    where OpenXmlElementType: DXO2013W.DataBinding, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.DataBinding openXmlElement, DMW.DataBinding3 value)
  {
    SetPrefixMappings(openXmlElement, value?.PrefixMappings);
    SetXPath(openXmlElement, value?.XPath);
    SetStoreItemId(openXmlElement, value?.StoreItemId);
  }
}

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
    return StringValueConverter.GetValue(openXmlElement?.PrefixMappings);
  }
  
  private static bool CmpPrefixMappings(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PrefixMappings, value, diffs, objName, "PrefixMappings");
  }
  
  private static void SetPrefixMappings(DXW.DataBinding openXmlElement, String? value)
  {
    openXmlElement.PrefixMappings = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  private static String? GetXPath(DXW.DataBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XPath);
  }
  
  private static bool CmpXPath(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XPath, value, diffs, objName, "XPath");
  }
  
  private static void SetXPath(DXW.DataBinding openXmlElement, String? value)
  {
    openXmlElement.XPath = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  private static String? GetStoreItemId(DXW.DataBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StoreItemId);
  }
  
  private static bool CmpStoreItemId(DXW.DataBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StoreItemId, value, diffs, objName, "StoreItemId");
  }
  
  private static void SetStoreItemId(DXW.DataBinding openXmlElement, String? value)
  {
    openXmlElement.StoreItemId = StringValueConverter.CreateStringValue(value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DataBinding value)
    where OpenXmlElementType: DXW.DataBinding, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DataBinding openXmlElement, DMW.DataBinding value)
  {
    SetPrefixMappings(openXmlElement, value?.PrefixMappings);
    SetXPath(openXmlElement, value?.XPath);
    SetStoreItemId(openXmlElement, value?.StoreItemId);
  }
}

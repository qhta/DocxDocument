namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Data Properties converter from/to OpenXml.
///</summary>
public static class DataStoreItemConverter
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  private static String? GetItemId(DXCustXmlDataProps.DataStoreItem openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ItemId);
  }
  
  private static bool CmpItemId(DXCustXmlDataProps.DataStoreItem openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ItemId, value, diffs, objName, "ItemId");
  }
  
  private static void SetItemId(DXCustXmlDataProps.DataStoreItem openXmlElement, String? value)
  {
    openXmlElement.ItemId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  private static DMCustXml.SchemaReferences? GetSchemaReferences(DXCustXmlDataProps.DataStoreItem openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXCustXmlDataProps.SchemaReferences>();
    if (element != null)
      return DMXCustXml.SchemaReferencesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemaReferences(DXCustXmlDataProps.DataStoreItem openXmlElement, DMCustXml.SchemaReferences? value, DiffList? diffs, string? objName)
  {
    return DMXCustXml.SchemaReferencesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCustXmlDataProps.SchemaReferences>(), value, diffs, objName);
  }
  
  private static void SetSchemaReferences(DXCustXmlDataProps.DataStoreItem openXmlElement, DMCustXml.SchemaReferences? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXCustXmlDataProps.SchemaReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXCustXml.SchemaReferencesConverter.CreateOpenXmlElement<DXCustXmlDataProps.SchemaReferences>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.CustomXml.DataStoreItem? CreateModelElement(DXCustXmlDataProps.DataStoreItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.DataStoreItem();
      value.ItemId = GetItemId(openXmlElement);
      value.SchemaReferences = GetSchemaReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustXmlDataProps.DataStoreItem? openXmlElement, DMCustXml.DataStoreItem? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItemId(openXmlElement, value.ItemId, diffs, objName))
        ok = false;
      if (!CmpSchemaReferences(openXmlElement, value.SchemaReferences, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.DataStoreItem value)
    where OpenXmlElementType: DXCustXmlDataProps.DataStoreItem, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCustXmlDataProps.DataStoreItem openXmlElement, DMCustXml.DataStoreItem value)
  {
    SetItemId(openXmlElement, value?.ItemId);
    SetSchemaReferences(openXmlElement, value?.SchemaReferences);
  }
}

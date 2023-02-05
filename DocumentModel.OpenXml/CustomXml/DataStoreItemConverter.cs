namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public static class DataStoreItemConverter
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  private static String? GetItemId(DXCustXmlDataProps.DataStoreItem openXmlElement)
  {
    return openXmlElement?.ItemId?.Value;
  }
  
  private static bool CmpItemId(DXCustXmlDataProps.DataStoreItem openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ItemId?.Value == value) return true;
    diffs?.Add(objName, "ItemId", openXmlElement?.ItemId?.Value, value);
    return false;
  }
  
  private static void SetItemId(DXCustXmlDataProps.DataStoreItem openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ItemId = new StringValue { Value = value };
    else
      openXmlElement.ItemId = null;
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  private static DMCustXml.SchemaReferences? GetSchemaReferences(DXCustXmlDataProps.DataStoreItem openXmlElement)
  {
    return DMXCustXml.SchemaReferencesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXCustXmlDataProps.SchemaReferences>());
  }
  
  private static bool CmpSchemaReferences(DXCustXmlDataProps.DataStoreItem openXmlElement, DMCustXml.SchemaReferences? value, DiffList? diffs, string? objName)
  {
    return DMXCustXml.SchemaReferencesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCustXmlDataProps.SchemaReferences>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMCustXml.DataStoreItem? CreateModelElement(DXCustXmlDataProps.DataStoreItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMCustXml.DataStoreItem();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.DataStoreItem? value)
    where OpenXmlElementType: DXCustXmlDataProps.DataStoreItem, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItemId(openXmlElement, value?.ItemId);
      SetSchemaReferences(openXmlElement, value?.SchemaReferences);
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public static class DataStoreItemConverter
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  private static String? GetItemId(DXCXDP.DataStoreItem openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ItemId);
  }
  
  private static bool CmpItemId(DXCXDP.DataStoreItem openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ItemId, value, diffs, objName, "ItemId");
  }
  
  private static void SetItemId(DXCXDP.DataStoreItem openXmlElement, String? value)
  {
    openXmlElement.ItemId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  private static DMCX.SchemaReferences? GetSchemaReferences(DXCXDP.DataStoreItem openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXCXDP.SchemaReferences>();
    if (element != null)
      return DMXCX.SchemaReferencesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemaReferences(DXCXDP.DataStoreItem openXmlElement, DMCX.SchemaReferences? value, DiffList? diffs, string? objName)
  {
    return DMXCX.SchemaReferencesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCXDP.SchemaReferences>(), value, diffs, objName);
  }
  
  private static void SetSchemaReferences(DXCXDP.DataStoreItem openXmlElement, DMCX.SchemaReferences? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXCXDP.SchemaReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXCX.SchemaReferencesConverter.CreateOpenXmlElement<DXCXDP.SchemaReferences>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.CustomXml.DataStoreItem? CreateModelElement(DXCXDP.DataStoreItem? openXmlElement)
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
  
  public static bool CompareModelElement(DXCXDP.DataStoreItem? openXmlElement, DMCX.DataStoreItem? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCX.DataStoreItem value)
    where OpenXmlElementType: DXCXDP.DataStoreItem, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCXDP.DataStoreItem openXmlElement, DMCX.DataStoreItem value)
  {
    SetItemId(openXmlElement, value?.ItemId);
    SetSchemaReferences(openXmlElement, value?.SchemaReferences);
  }
}

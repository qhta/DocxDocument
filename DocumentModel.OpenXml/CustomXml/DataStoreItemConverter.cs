namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public static class DataStoreItemConverter
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public static String? GetItemId(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? openXmlElement)
  {
    return openXmlElement?.ItemId?.Value;
  }
  
  public static void SetItemId(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ItemId = new StringValue { Value = value };
      else
        openXmlElement.ItemId = null;
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public static DocumentModel.CustomXml.SchemaReferences? GetSchemaReferences(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CustomXml.SchemaReferencesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemaReferences(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? openXmlElement, DocumentModel.CustomXml.SchemaReferences? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.CustomXml.SchemaReferencesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.CustomXml.DataStoreItem? CreateModelElement(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.DataStoreItem? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem, new()
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

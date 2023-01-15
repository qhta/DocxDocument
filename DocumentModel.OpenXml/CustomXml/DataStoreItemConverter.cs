using DocumentFormat.OpenXml.CustomXmlDataProperties;
using SchemaReferences = DocumentModel.CustomXml.SchemaReferences;

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
///   Custom XML Data Properties.
/// </summary>
public static class DataStoreItemConverter
{
  /// <summary>
  ///   Custom XML Data ID
  /// </summary>
  public static String? GetItemId(DataStoreItem? openXmlElement)
  {
    return openXmlElement?.ItemId?.Value;
  }

  public static void SetItemId(DataStoreItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ItemId = new StringValue { Value = value };
      else
        openXmlElement.ItemId = null;
  }

  /// <summary>
  ///   Set of Associated XML Schemas.
  /// </summary>
  public static SchemaReferences? GetSchemaReferences(DataStoreItem? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
    if (itemElement != null)
      return SchemaReferencesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemaReferences(DataStoreItem? openXmlElement, SchemaReferences? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemaReferencesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.CustomXml.DataStoreItem? CreateModelElement(DataStoreItem? openXmlElement)
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
    where OpenXmlElementType : DataStoreItem, new()
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
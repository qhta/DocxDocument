namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public class DataStoreItemImpl: ModelElement<DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem>, DataStoreItem
{
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences
  {
    get;
    set;
  }
  
}

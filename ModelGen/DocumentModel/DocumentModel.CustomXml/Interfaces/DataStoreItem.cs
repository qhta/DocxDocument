namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public interface DataStoreItem
{
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences { get ; set; }
  
}

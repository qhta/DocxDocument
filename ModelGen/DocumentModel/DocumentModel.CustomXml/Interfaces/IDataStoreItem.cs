namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public interface IDataStoreItem // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public System.String? ItemId { get ; set; }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public DocumentModel.CustomXml.ISchemaReferences? SchemaReferences { get ; set; }
  
}

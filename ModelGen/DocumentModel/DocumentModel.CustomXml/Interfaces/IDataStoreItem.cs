namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public interface IDataStoreItem // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public String? ItemId { get ; set; }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public ISchemaReferences? SchemaReferences { get ; set; }
  
}

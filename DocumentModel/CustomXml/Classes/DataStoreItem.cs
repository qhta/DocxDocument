namespace DocumentModel.CustomXml;

/// <summary>
///   Custom XML Data Properties.
/// </summary>
public record DataStoreItem
{
  /// <summary>
  ///   Custom XML Data ID
  /// </summary>
  public String? ItemId { get; set; }

  /// <summary>
  ///   Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences { get; set; }
}
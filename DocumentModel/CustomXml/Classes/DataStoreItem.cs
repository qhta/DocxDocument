namespace DocumentModel.CustomXml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom XML Data Properties.
/// </summary>
public class DataStoreItem: ModelElement
{
  /// <summary>
  ///   Custom XML Data ID
  /// </summary>
  public string? ItemId { get; set; }

  /// <summary>
  ///   Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences { get; set; }
}
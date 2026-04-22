namespace DocumentModel.CustomXml;

#pragma warning disable CS1591

public partial class DataStoreItem
{
  public bool ShouldSerializeItemId() => !String.IsNullOrEmpty(ItemId);
  public bool ShouldSerializeSchemaReferences() => SchemaReferences is not null;
}

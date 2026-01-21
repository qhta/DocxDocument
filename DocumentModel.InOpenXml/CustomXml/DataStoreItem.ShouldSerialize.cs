namespace DocumentModel.CustomXml;

public partial class DataStoreItem
{
  public bool ShouldSerializeItemId() => ItemId is not null;
  public bool ShouldSerializeSchemaReferences() => SchemaReferences is not null;
}

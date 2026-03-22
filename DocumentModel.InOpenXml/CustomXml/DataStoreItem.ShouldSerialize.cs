namespace DocumentModel.CustomXml;
#pragma warning disable CS1591
public partial class DataStoreItem
{
  public bool ShouldSerializeItemId() => ItemId is not null;
  public bool ShouldSerializeSchemaReferences() => SchemaReferences is not null;
}

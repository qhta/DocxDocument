namespace DocumentModel.CustomXml;
#pragma warning disable CS1591
public partial class Schema
{
  public bool ShouldSerializeUri() => Uri is not null;
  public bool ShouldSerializeManifestLocation() => ManifestLocation is not null;
  public bool ShouldSerializeSchemaLocation() => SchemaLocation is not null;
}

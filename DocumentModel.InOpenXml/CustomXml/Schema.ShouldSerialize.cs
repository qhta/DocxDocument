namespace DocumentModel.CustomXml;

#pragma warning disable CS1591

public partial class Schema
{
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
  public bool ShouldSerializeManifestLocation() => !String.IsNullOrEmpty(ManifestLocation);
  public bool ShouldSerializeSchemaLocation() => !String.IsNullOrEmpty(SchemaLocation);
}

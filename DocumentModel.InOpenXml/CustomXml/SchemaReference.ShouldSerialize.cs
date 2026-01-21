namespace DocumentModel.CustomXml;

public partial class SchemaReference
{
  public bool ShouldSerializeUriString() => UriString is not null;
}

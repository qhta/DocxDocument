namespace DocumentModel.CustomXml;

#pragma warning disable CS1591

public partial class SchemaReference
{
  public bool ShouldSerializeUriString() => !String.IsNullOrEmpty(UriString);
}

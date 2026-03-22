namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CustomXmlAttribute
{
  public bool ShouldSerializeUriString() => UriString is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeVal() => Val is not null;
}

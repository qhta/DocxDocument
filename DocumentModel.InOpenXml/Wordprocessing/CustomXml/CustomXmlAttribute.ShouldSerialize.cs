namespace DocumentModel.Wordprocessing;

public partial class CustomXmlAttribute
{
  public bool ShouldSerializeUriString() => UriString is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeVal() => Val is not null;
}

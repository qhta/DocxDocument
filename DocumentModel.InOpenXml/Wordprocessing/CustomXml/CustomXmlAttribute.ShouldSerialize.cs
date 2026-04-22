namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CustomXmlAttribute
{
  public bool ShouldSerializeUriString() => !String.IsNullOrEmpty(UriString);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
}

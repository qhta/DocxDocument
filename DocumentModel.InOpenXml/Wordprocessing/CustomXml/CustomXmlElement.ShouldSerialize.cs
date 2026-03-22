namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CustomXmlElement
{
  public bool ShouldSerializeUriString() => UriString is not null;
  public bool ShouldSerializeElement() => Element is not null;
  public bool ShouldSerializeCustomXmlProperties() => CustomXmlProperties is not null;
}

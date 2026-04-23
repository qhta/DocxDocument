namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CustomXmlElement
{
  public bool ShouldSerializeUriString() => !String.IsNullOrEmpty(UriString);
  public bool ShouldSerializeElement() => !String.IsNullOrEmpty(Element);
  public bool ShouldSerializeCustomXmlProperties() => CustomXmlProperties is not null && ShouldSerialize(CustomXmlProperties);
}

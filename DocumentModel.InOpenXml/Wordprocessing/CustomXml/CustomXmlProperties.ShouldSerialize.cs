namespace DocumentModel.Wordprocessing;

public partial class CustomXmlProperties
{
  public bool ShouldSerializeCustomXmlPlaceholder() => CustomXmlPlaceholder is not null;
}

namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CustomXmlProperties
{
  public bool ShouldSerializeCustomXmlPlaceholder() => !String.IsNullOrEmpty(CustomXmlPlaceholder);
}

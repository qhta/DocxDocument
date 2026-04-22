namespace DocumentModel;

#pragma warning disable CS1591

public partial class ContentProperties
{
  public bool ShouldSerializeTemplate() => !String.IsNullOrEmpty(Template);
  public bool ShouldSerializeManager() => !String.IsNullOrEmpty(Manager);
  public bool ShouldSerializeCompany() => !String.IsNullOrEmpty(Company);
  public bool ShouldSerializePresentationFormat() => !String.IsNullOrEmpty(PresentationFormat);
  public bool ShouldSerializeScaleCrop() => ScaleCrop is not null;
  public bool ShouldSerializeHeadingPairs() => HeadingPairs is not null;
  public bool ShouldSerializeTitlesOfParts() => TitlesOfParts is not null;
  public bool ShouldSerializeLinksUpToDate() => LinksUpToDate is not null;
  public bool ShouldSerializeSharedDocument() => SharedDocument is not null;
  public bool ShouldSerializeHyperlinkBase() => !String.IsNullOrEmpty(HyperlinkBase);
  public bool ShouldSerializeHyperlinkList() => HyperlinkList is not null;
  public bool ShouldSerializeHyperlinksChanged() => HyperlinksChanged is not null;
  public bool ShouldSerializeDocumentSecurity() => DocumentSecurity is not null;
  public bool ShouldSerializeDigitalSignature() => DigitalSignature is not null;
  public bool ShouldSerializeApplication() => !String.IsNullOrEmpty(Application);
  public bool ShouldSerializeApplicationVersion() => !String.IsNullOrEmpty(ApplicationVersion);
}

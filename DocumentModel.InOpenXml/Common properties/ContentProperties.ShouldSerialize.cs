namespace DocumentModel;

#pragma warning disable CS1591

public partial class ContentProperties
{
  public bool ShouldSerializeTemplate() => Template is not null;
  public bool ShouldSerializeManager() => Manager is not null;
  public bool ShouldSerializeCompany() => Company is not null;
  public bool ShouldSerializePresentationFormat() => PresentationFormat is not null;
  public bool ShouldSerializeScaleCrop() => ScaleCrop is not null;
  public bool ShouldSerializeHeadingPairs() => HeadingPairs is not null && HeadingPairs.Any();
  public bool ShouldSerializeTitlesOfParts() => TitlesOfParts is not null;
  public bool ShouldSerializeLinksUpToDate() => LinksUpToDate is not null;
  public bool ShouldSerializeSharedDocument() => SharedDocument is not null;
  public bool ShouldSerializeHyperlinkBase() => HyperlinkBase is not null;
  public bool ShouldSerializeHyperlinkList() => HyperlinkList is not null;
  public bool ShouldSerializeHyperlinksChanged() => HyperlinksChanged is not null;
  public bool ShouldSerializeDocumentSecurity() => DocumentSecurity is not null;
  public bool ShouldSerializeDigitalSignature() => DigitalSignature is not null;
  public bool ShouldSerializeApplication() => Application is not null;
  public bool ShouldSerializeApplicationVersion() => ApplicationVersion is not null;
}

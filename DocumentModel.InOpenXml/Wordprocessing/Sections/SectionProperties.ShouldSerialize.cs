namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SectionProperties
{
  public bool ShouldSerializeHeaderReferences() => HeaderReferences is not null;
  public bool ShouldSerializeFooterReferences() => FooterReferences is not null;
  public bool ShouldSerializeSectionPropertiesChange() => SectionPropertiesChange is not null;
}

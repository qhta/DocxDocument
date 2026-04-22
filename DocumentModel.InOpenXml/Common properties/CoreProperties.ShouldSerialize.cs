namespace DocumentModel;

#pragma warning disable CS1591

public partial class CoreProperties
{
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeSubject() => !String.IsNullOrEmpty(Subject);
  public bool ShouldSerializeCreator() => !String.IsNullOrEmpty(Creator);
  public bool ShouldSerializeKeywords() => !String.IsNullOrEmpty(Keywords);
  public bool ShouldSerializeDescription() => !String.IsNullOrEmpty(Description);
  public bool ShouldSerializeLastModifiedBy() => !String.IsNullOrEmpty(LastModifiedBy);
  public bool ShouldSerializeRevision() => Revision is not null;
  public bool ShouldSerializeLastPrinted() => LastPrinted is not null;
  public bool ShouldSerializeCreated() => Created is not null;
  public bool ShouldSerializeModified() => Modified is not null;
  public bool ShouldSerializeCategory() => !String.IsNullOrEmpty(Category);
  public bool ShouldSerializeIdentifier() => !String.IsNullOrEmpty(Identifier);
  public bool ShouldSerializeContentType() => !String.IsNullOrEmpty(ContentType);
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeVersion() => !String.IsNullOrEmpty(Version);
  public bool ShouldSerializeContentStatus() => !String.IsNullOrEmpty(ContentStatus);
}

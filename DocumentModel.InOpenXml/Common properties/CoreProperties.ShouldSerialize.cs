namespace DocumentModel;

#pragma warning disable CS1591

public partial class CoreProperties
{
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeSubject() => Subject is not null;
  public bool ShouldSerializeCreator() => Creator is not null;
  public bool ShouldSerializeKeywords() => Keywords is not null;
  public bool ShouldSerializeDescription() => Description is not null;
  public bool ShouldSerializeLastModifiedBy() => LastModifiedBy is not null;
  public bool ShouldSerializeRevision() => Revision is not null;
  public bool ShouldSerializeLastPrinted() => LastPrinted is not null;
  public bool ShouldSerializeCreated() => Created is not null;
  public bool ShouldSerializeModified() => Modified is not null;
  public bool ShouldSerializeCategory() => Category is not null;
  public bool ShouldSerializeIdentifier() => Identifier is not null;
  public bool ShouldSerializeContentType() => ContentType is not null;
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeVersion() => Version is not null;
  public bool ShouldSerializeContentStatus() => ContentStatus is not null;
}

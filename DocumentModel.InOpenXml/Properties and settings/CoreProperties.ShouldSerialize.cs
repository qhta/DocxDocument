namespace DocumentModel;

public partial class CoreProperties
{
  public bool ShouldSerializeTitle() => Title != null;
  public bool ShouldSerializeSubject() => Subject != null;
  public bool ShouldSerializeCreator() => Creator != null;
  public bool ShouldSerializeKeywords() => Keywords != null;
  public bool ShouldSerializeDescription() => Description != null;
  public bool ShouldSerializeLastModifiedBy() => LastModifiedBy != null;
  public bool ShouldSerializeRevision() => Revision.HasValue;
  public bool ShouldSerializeLastPrinted() => LastPrinted.HasValue;
  public bool ShouldSerializeCreated() => Created.HasValue;
  public bool ShouldSerializeModified() => Modified.HasValue;
  public bool ShouldSerializeCategory() => Category != null;
  public bool ShouldSerializeIdentifier() => Identifier != null;
  public bool ShouldSerializeContentType() => ContentType != null;
  public bool ShouldSerializeLanguage() => Language != null;
  public bool ShouldSerializeVersion() => Version != null;
  public bool ShouldSerializeContentStatus() => ContentStatus != null;
}

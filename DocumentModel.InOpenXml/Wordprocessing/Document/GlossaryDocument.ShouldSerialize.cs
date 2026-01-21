namespace DocumentModel.Wordprocessing;

public partial class GlossaryDocument
{
  public bool ShouldSerializeDocumentBackground() => DocumentBackground is not null;
  public bool ShouldSerializeDocParts() => DocParts is not null;
}

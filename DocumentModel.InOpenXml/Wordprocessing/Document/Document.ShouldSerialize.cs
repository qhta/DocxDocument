namespace DocumentModel.Wordprocessing;

public partial class Document
{
  public bool ShouldSerializeWordprocessingDocument() => WordprocessingDocument is not null;
  public bool ShouldSerializeCustomProperties() => CustomProperties is not null;
  public bool ShouldSerializeDocumentSettings() => DocumentSettings is not null;
}

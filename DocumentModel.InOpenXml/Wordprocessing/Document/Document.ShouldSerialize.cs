namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Document
{
  public bool ShouldSerializeWordprocessingDocument() => WordprocessingDocument is not null;
  public bool ShouldSerializeCustomProperties() => CustomProperties is not null;
  public bool ShouldSerializeDocumentSettings() => DocumentSettings is not null;
  public bool ShouldSerializeRsids() => Rsids is not null;
  public bool ShouldSerializeFonts() => FontTableTable is not null;
}

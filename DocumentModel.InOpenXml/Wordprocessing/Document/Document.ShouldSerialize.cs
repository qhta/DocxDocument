namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Document
{
  public bool ShouldSerializeWordprocessingDocument() => WordprocessingDocument is not null && ShouldSerialize(WordprocessingDocument);
  public bool ShouldSerializeFilename() => !String.IsNullOrEmpty(Filename);
  public bool ShouldSerializeIsEditable() => IsEditable == true;
  public bool ShouldSerializeRsids() => Rsids is not null && ShouldSerialize(Rsids);
  public bool ShouldSerializeDocumentVariables() => DocumentVariables is not null && ShouldSerialize(DocumentVariables);
  public bool ShouldSerializeFontTableTable() => FontTableTable is not null && ShouldSerialize(FontTableTable);
  public bool ShouldSerializeTheme() => Theme is not null && ShouldSerialize(Theme);
  public bool ShouldSerializeStyles() => Styles is not null && ShouldSerialize(Styles);
  public bool ShouldSerializeNumbering() => Numbering is not null && ShouldSerialize(Numbering);
}

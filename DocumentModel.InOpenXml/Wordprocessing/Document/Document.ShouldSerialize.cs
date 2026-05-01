namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Document
{
  public bool ShouldSerializeWordprocessingDocument() => WordprocessingDocument is not null && ShouldSerialize(WordprocessingDocument);
  public bool ShouldSerializeFilename() => !String.IsNullOrEmpty(Filename);
  public bool ShouldSerializeIsEditable() => IsEditable == true;
  public bool ShouldSerializeRsids() => _Rsids is not null && ShouldSerialize(Rsids);
  public bool ShouldSerializeDocumentVariables() => _DocumentVariables is not null && ShouldSerialize(DocumentVariables);
  public bool ShouldSerializeFontTable() => _FontTable is not null && ShouldSerialize(FontTable);
  public bool ShouldSerializeTheme() => _Theme is not null && ShouldSerialize(Theme);
  public bool ShouldSerializeStyles() => _Styles is not null && ShouldSerialize(Styles);
  public bool ShouldSerializeNumbering() => _Numbering is not null && ShouldSerialize(Numbering);
}

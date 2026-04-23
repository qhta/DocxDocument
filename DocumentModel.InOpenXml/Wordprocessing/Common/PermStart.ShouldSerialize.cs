namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PermStart
{
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null && ShouldSerialize(ColumnFirst);
  public bool ShouldSerializeColumnLast() => ColumnLast is not null && ShouldSerialize(ColumnLast);
  public bool ShouldSerializeEditorGroup() => EditorGroup is not null && ShouldSerialize(EditorGroup);
  public bool ShouldSerializeEd() => !String.IsNullOrEmpty(Ed);
}

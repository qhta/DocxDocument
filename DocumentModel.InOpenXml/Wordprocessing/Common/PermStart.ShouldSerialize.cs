namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class PermStart
{
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null;
  public bool ShouldSerializeColumnLast() => ColumnLast is not null;
  public bool ShouldSerializeEditorGroup() => EditorGroup is not null;
  public bool ShouldSerializeEd() => Ed is not null;
}

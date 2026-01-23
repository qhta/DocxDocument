namespace DocumentModel.Wordprocessing;

public partial class TextColumns
{
  public bool ShouldSerializeEqualWidth() => EqualWidth is not null;
  public bool ShouldSerializeSpace() => Space is not null;
  public bool ShouldSerializeColumnCount() => ColumnCount is not null;
  public bool ShouldSerializeSeparator() => Separator is not null;
}

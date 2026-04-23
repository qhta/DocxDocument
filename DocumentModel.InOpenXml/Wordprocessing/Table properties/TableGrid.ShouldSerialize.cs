namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableGrid
{
  public bool ShouldSerializeTableGridChange() => TableGridChange is not null && ShouldSerialize(TableGridChange);
}

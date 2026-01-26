namespace DocumentModel.Wordprocessing;

public partial class CurrentTableProperties<T>
{
  public bool ShouldSerializeTableWidth() => TableWidth is not null;
  public bool ShouldSerializeTableLayout() => TableLayout is not null;
  public bool ShouldSerializeTableLook() => TableLook is not null;
}

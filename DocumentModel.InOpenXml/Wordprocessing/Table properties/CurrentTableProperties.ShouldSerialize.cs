namespace DocumentModel.Wordprocessing;

public partial class CurrentTableProperties
{
  public bool ShouldSerializeTableWidth() => TableWidth is not null;
  public bool ShouldSerializeTableLayout() => TableLayout is not null;
  public bool ShouldSerializeTableLook() => TableLook is not null;
}

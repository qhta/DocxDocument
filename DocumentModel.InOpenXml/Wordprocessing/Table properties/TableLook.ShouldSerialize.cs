namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TableLook
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeFirstRow() => FirstRow is not null;
  public bool ShouldSerializeLastRow() => LastRow is not null;
  public bool ShouldSerializeFirstColumn() => FirstColumn is not null;
  public bool ShouldSerializeLastColumn() => LastColumn is not null;
  public bool ShouldSerializeNoHorizontalBand() => NoHorizontalBand is not null;
  public bool ShouldSerializeNoVerticalBand() => NoVerticalBand is not null;
}

namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableCellMargin
{
  public bool ShouldSerializeTopMargin() => TopMargin is not null;
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null;
  public bool ShouldSerializeStartMargin() => StartMargin is not null;
  public bool ShouldSerializeBottomMargin() => BottomMargin is not null;
  public bool ShouldSerializeRightMargin() => RightMargin is not null;
  public bool ShouldSerializeEndMargin() => EndMargin is not null;
}

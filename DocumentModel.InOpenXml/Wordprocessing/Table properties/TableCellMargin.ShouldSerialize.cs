namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableCellMargin
{
  public bool ShouldSerializeTopMargin() => TopMargin is not null && ShouldSerialize(TopMargin);
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null && ShouldSerialize(LeftMargin);
  public bool ShouldSerializeStartMargin() => StartMargin is not null && ShouldSerialize(StartMargin);
  public bool ShouldSerializeBottomMargin() => BottomMargin is not null && ShouldSerialize(BottomMargin);
  public bool ShouldSerializeRightMargin() => RightMargin is not null && ShouldSerialize(RightMargin);
  public bool ShouldSerializeEndMargin() => EndMargin is not null && ShouldSerialize(EndMargin);
}

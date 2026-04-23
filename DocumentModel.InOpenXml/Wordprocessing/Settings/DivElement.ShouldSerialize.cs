namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DivElement
{
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
  public bool ShouldSerializeIsBlockQuote() => IsBlockQuote is not null;
  public bool ShouldSerializeIsBody() => IsBody is not null;
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null && ShouldSerialize(LeftMargin);
  public bool ShouldSerializeRightMargin() => RightMargin is not null && ShouldSerialize(RightMargin);
  public bool ShouldSerializeTopMargin() => TopMargin is not null && ShouldSerialize(TopMargin);
  public bool ShouldSerializeBottomMargin() => BottomMargin is not null && ShouldSerialize(BottomMargin);
  public bool ShouldSerializeDivBorder() => DivBorder is not null && ShouldSerialize(DivBorder);
  public bool ShouldSerializeChildren() => Children is not null && ShouldSerialize(Children);
}

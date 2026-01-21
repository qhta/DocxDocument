namespace DocumentModel.Wordprocessing;

public partial class DivElement
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeIsBlockQuote() => IsBlockQuote is not null;
  public bool ShouldSerializeIsBody() => IsBody is not null;
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null;
  public bool ShouldSerializeRightMargin() => RightMargin is not null;
  public bool ShouldSerializeTopMargin() => TopMargin is not null;
  public bool ShouldSerializeBottomMargin() => BottomMargin is not null;
  public bool ShouldSerializeDivBorder() => DivBorder is not null;
  public bool ShouldSerializeChildren() => Children is not null;
}

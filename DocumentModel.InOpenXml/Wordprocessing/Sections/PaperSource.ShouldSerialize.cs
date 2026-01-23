namespace DocumentModel.Wordprocessing;

public partial class PaperSource
{
  public bool ShouldSerializeFirst() => First is not null;
  public bool ShouldSerializeOther() => Other is not null;
}

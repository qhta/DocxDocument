namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class PaperSource
{
  public bool ShouldSerializeFirst() => First is not null;
  public bool ShouldSerializeOther() => Other is not null;
}

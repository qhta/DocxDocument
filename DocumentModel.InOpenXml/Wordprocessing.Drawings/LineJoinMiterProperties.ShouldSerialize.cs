namespace DocumentModel.Wordprocessing.Drawings;

public partial class LineJoinMiterProperties
{
  public bool ShouldSerializeLimit() => Limit is not null;
}

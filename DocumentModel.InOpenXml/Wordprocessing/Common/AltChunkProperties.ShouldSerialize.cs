namespace DocumentModel.Wordprocessing;

public partial class AltChunkProperties
{
  public bool ShouldSerializeMatchSource() => MatchSource is not null;
}

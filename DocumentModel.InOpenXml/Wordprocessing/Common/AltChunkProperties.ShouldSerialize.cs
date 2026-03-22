namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class AltChunkProperties
{
  public bool ShouldSerializeMatchSource() => MatchSource is not null;
}

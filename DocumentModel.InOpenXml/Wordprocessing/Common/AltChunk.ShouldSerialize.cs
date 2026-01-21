namespace DocumentModel.Wordprocessing;

public partial class AltChunk
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAltChunkProperties() => AltChunkProperties is not null;
}

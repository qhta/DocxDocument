namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AltChunk
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAltChunkProperties() => AltChunkProperties is not null;
}

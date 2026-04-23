namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AltChunk
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeAltChunkProperties() => AltChunkProperties is not null && ShouldSerialize(AltChunkProperties);
}

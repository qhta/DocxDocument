namespace DocumentModel.Drawings;

public partial class ArtisticGlowEdges
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeSmoothness() => Smoothness is not null;
}

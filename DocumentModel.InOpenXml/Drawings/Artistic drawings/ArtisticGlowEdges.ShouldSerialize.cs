namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ArtisticGlowEdges
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeSmoothness() => Smoothness is not null;
}

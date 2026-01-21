namespace DocumentModel.Drawings;

public partial class FillOverlay
{
  public bool ShouldSerializeBlend() => Blend is not null;
  public bool ShouldSerializeFill() => Fill is not null;
}

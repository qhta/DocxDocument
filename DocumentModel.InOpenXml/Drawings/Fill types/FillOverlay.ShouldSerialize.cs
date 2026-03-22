namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class FillOverlay
{
  public bool ShouldSerializeBlend() => Blend is not null;
  public bool ShouldSerializeFill() => Fill is not null;
}

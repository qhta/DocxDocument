namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Break
{
  public bool ShouldSerializeAlignAt() => AlignAt is not null;
}

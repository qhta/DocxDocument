namespace DocumentModel.Math;

public partial class Break
{
  public bool ShouldSerializeAlignAt() => AlignAt is not null;
}

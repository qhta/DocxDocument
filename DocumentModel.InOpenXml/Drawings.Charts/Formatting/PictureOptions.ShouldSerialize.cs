namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PictureOptions
{
  public bool ShouldSerializeApplyToFront() => ApplyToFront is not null;
  public bool ShouldSerializeApplyToSides() => ApplyToSides is not null;
  public bool ShouldSerializeApplyToEnd() => ApplyToEnd is not null;
  public bool ShouldSerializePictureFormat() => PictureFormat is not null;
  public bool ShouldSerializePictureStackUnit() => PictureStackUnit is not null;
}

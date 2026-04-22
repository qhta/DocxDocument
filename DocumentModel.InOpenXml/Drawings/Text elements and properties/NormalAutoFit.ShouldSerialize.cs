namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NormalAutoFit
{
  public bool ShouldSerializeFontScale() => FontScale is not null;
  public bool ShouldSerializeLineSpaceReduction() => LineSpaceReduction is not null;
}

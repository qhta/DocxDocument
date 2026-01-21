namespace DocumentModel.Drawings;

public partial class NormalAutoFit
{
  public bool ShouldSerializeFontScale() => FontScale is not null;
  public bool ShouldSerializeLineSpaceReduction() => LineSpaceReduction is not null;
}

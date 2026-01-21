namespace DocumentModel.Math;

public partial class SubSuperscriptProperties
{
  public bool ShouldSerializeAlignScripts() => AlignScripts is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}

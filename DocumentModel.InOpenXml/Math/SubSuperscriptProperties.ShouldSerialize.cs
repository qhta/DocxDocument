namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class SubSuperscriptProperties
{
  public bool ShouldSerializeAlignScripts() => AlignScripts is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}

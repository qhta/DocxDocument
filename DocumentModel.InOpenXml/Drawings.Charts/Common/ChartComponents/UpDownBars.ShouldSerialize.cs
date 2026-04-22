namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class UpDownBars
{
  public bool ShouldSerializeGapWidth() => GapWidth is not null;
  public bool ShouldSerializeUpBars() => UpBars is not null;
  public bool ShouldSerializeDownBars() => DownBars is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

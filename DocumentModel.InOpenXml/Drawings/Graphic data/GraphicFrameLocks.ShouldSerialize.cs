namespace DocumentModel.Drawings;

public partial class GraphicFrameLocks
{
  public bool ShouldSerializeNoGrouping() => NoGrouping is not null;
  public bool ShouldSerializeNoDrilldown() => NoDrilldown is not null;
  public bool ShouldSerializeNoSelection() => NoSelection is not null;
  public bool ShouldSerializeNoChangeAspect() => NoChangeAspect is not null;
  public bool ShouldSerializeNoMove() => NoMove is not null;
  public bool ShouldSerializeNoResize() => NoResize is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

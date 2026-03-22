namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class PictureLocks
{
  public bool ShouldSerializeNoGrouping() => NoGrouping is not null;
  public bool ShouldSerializeNoSelection() => NoSelection is not null;
  public bool ShouldSerializeNoRotation() => NoRotation is not null;
  public bool ShouldSerializeNoChangeAspect() => NoChangeAspect is not null;
  public bool ShouldSerializeNoMove() => NoMove is not null;
  public bool ShouldSerializeNoResize() => NoResize is not null;
  public bool ShouldSerializeNoEditPoints() => NoEditPoints is not null;
  public bool ShouldSerializeNoAdjustHandles() => NoAdjustHandles is not null;
  public bool ShouldSerializeNoChangeArrowheads() => NoChangeArrowheads is not null;
  public bool ShouldSerializeNoChangeShapeType() => NoChangeShapeType is not null;
  public bool ShouldSerializeNoCrop() => NoCrop is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

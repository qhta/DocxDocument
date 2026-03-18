namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Chart
{
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeAutoTitleDeleted() => AutoTitleDeleted is not null;
  public bool ShouldSerializePivotFormats() => PivotFormats is not null;
  public bool ShouldSerializeView3D() => View3D is not null;
  public bool ShouldSerializeFloor() => Floor is not null;
  public bool ShouldSerializeSideWall() => SideWall is not null;
  public bool ShouldSerializeBackWall() => BackWall is not null;
  public bool ShouldSerializePlotArea() => PlotArea is not null;
  public bool ShouldSerializeLegend() => Legend is not null;
  public bool ShouldSerializePlotVisibleOnly() => PlotVisibleOnly is not null;
  public bool ShouldSerializeDisplayBlanksAs() => DisplayBlanksAs is not null;
  public bool ShouldSerializeShowDataLabelsOverMaximum() => ShowDataLabelsOverMaximum is not null;
}

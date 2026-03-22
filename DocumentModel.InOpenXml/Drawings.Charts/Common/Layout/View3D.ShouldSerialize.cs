namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class View3D
{
  public bool ShouldSerializeRotateX() => RotateX is not null;
  public bool ShouldSerializeHeightPercent() => HeightPercent is not null;
  public bool ShouldSerializeRotateY() => RotateY is not null;
  public bool ShouldSerializeDepthPercent() => DepthPercent is not null;
  public bool ShouldSerializeRightAngleAxes() => RightAngleAxes is not null;
  public bool ShouldSerializePerspective() => Perspective is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}

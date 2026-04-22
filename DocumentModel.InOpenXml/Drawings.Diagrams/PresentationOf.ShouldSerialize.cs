namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class PresentationOf
{
  public bool ShouldSerializeAxis() => Axis is not null;
  public bool ShouldSerializePointType() => PointType is not null;
  public bool ShouldSerializeHideLastTrans() => HideLastTrans is not null;
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeCount() => Count is not null;
  public bool ShouldSerializeStep() => Step is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

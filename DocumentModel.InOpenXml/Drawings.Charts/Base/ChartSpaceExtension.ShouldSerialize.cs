namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class ChartSpaceExtension
{
  public bool ShouldSerializePivotOptions() => PivotOptions is not null;
  public bool ShouldSerializeSketchOptions() => SketchOptions is not null;
  public bool ShouldSerializePivotSource() => PivotSource is not null;
}

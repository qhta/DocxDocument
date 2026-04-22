namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class NonVisualContentPartProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualInkContentPartProperties() => NonVisualInkContentPartProperties is not null;
}

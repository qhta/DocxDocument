namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ApplicationNonVisualDrawingProperties
{
  public bool ShouldSerializeMacro() => !String.IsNullOrEmpty(Macro);
  public bool ShouldSerializePublished() => Published is not null;
}

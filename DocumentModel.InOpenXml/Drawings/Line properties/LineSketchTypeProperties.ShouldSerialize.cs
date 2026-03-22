namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class LineSketchTypeProperties
{
  public bool ShouldSerializeLineSketchNoneEmpty() => LineSketchNoneEmpty is not null;
  public bool ShouldSerializeLineSketchCurvedEmpty() => LineSketchCurvedEmpty is not null;
  public bool ShouldSerializeLineSketchFreehandEmpty() => LineSketchFreehandEmpty is not null;
  public bool ShouldSerializeLineSketchScribbleEmpty() => LineSketchScribbleEmpty is not null;
}

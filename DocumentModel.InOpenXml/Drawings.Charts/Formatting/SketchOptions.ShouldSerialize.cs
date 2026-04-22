namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class SketchOptions
{
  public bool ShouldSerializeInSketchMode() => InSketchMode is not null;
  public bool ShouldSerializeShowSketchButton() => ShowSketchButton is not null;
}

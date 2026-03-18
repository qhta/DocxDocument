namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class LineReference
{
  public bool ShouldSerializeStyleColor() => StyleColor is not null;
}

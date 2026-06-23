namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class GradientStop
{
  public bool ShouldSerializePosition() => Position is not null;

  public bool ShouldSerializeColor() => Color is not null;
}

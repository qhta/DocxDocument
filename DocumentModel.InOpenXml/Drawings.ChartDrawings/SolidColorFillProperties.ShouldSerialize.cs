namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class SolidColorFillProperties
{
  public bool ShouldSerializeColor() => Color is not null;
}

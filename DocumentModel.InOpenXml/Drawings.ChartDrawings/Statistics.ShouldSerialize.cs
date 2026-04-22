namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Statistics
{
  public bool ShouldSerializeQuartileMethod() => QuartileMethod is not null;
}

namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class SeriesElementVisibilities
{
  public bool ShouldSerializeConnectorLines() => ConnectorLines is not null;
  public bool ShouldSerializeMeanLine() => MeanLine is not null;
  public bool ShouldSerializeMeanMarker() => MeanMarker is not null;
  public bool ShouldSerializeNonoutliers() => Nonoutliers is not null;
  public bool ShouldSerializeOutliers() => Outliers is not null;
}

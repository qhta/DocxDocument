namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents external data referenced by a chart.
///   This interface defines the relationship to the external data source and whether it should update automatically.
/// </summary>
public interface ExternalData
{
  /// <summary>
  ///   Relationship reference identifier to the external data part.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Indicates whether the data source updates automatically when the chart is refreshed.
  /// </summary>
  public bool? AutoUpdate { get; set; }
}
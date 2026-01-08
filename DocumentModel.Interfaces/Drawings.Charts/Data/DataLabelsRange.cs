namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a range of data labels in a chart, defined by a formula and an associated cache.
///   This interface allows referencing a cell range for data labels and storing cached values for efficient access and rendering.
/// </summary>
public interface DataLabelsRange
{
  /// <summary>
  ///   Formula that defines the cell range used for the data labels.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   Cache containing the values and metadata for the data labels range.
  /// </summary>
  public DataLabelsRangeCache? DataLabelsRangeCache { get; set; }
} 
namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents text associated with a chart series.
///   This interface defines either a reference to a string data source or a direct numeric value used as text.
/// </summary>
public interface SeriesText
{
  /// <summary>
  ///   Reference to a string data source used for the series text.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Numeric value displayed as text for the series.
  /// </summary>
  public string? NumericValue { get; set; }
}
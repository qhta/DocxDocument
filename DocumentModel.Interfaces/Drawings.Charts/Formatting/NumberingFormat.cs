namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the number formatting options for chart values or labels.
///   This interface allows specifying a custom format code and whether the format is linked to the source data.
/// </summary>
public interface NumberingFormat
{
  /// <summary>
  ///   Format code that defines how numbers are displayed, such as currency, percentage, or custom patterns.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Indicates whether the number format is linked to the source data.
  ///   If true, the format will automatically update to match the source.
  /// </summary>
  public bool? SourceLinked { get; set; }
}
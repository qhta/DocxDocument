namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the number formatting options for chart values or labels (version 3).
///   This interface allows specifying a custom format code and whether the format is linked to the source data.
/// </summary>
public interface NumberingFormat3
{
  /// <summary>
  ///   Format code that defines how numbers are displayed.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Indicates whether the number format is linked to the source data.
  /// </summary>
  public bool? SourceLinked { get; set; }
}
namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Series Text.
/// </summary>
public record SeriesText
{
  /// <summary>
  ///   StringReference.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   NumericValue.
  /// </summary>
  public String? NumericValue { get; set; }
}
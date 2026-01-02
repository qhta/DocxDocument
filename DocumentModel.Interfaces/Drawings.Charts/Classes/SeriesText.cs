namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Series Text.
/// </summary>
public class SeriesText: ModelElement
{
  /// <summary>
  ///   StringReference.
  /// </summary>
  public StringReference? StringReference { get; set; }
  /// <summary>
  ///   NumericValue.
  /// </summary>
  public string? NumericValue { get; set; }
}
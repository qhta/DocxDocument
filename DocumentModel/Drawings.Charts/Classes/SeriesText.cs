namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
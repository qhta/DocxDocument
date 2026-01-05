namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
public interface NumericLevel:
{
  /// <summary>
  ///   ptCount
  /// </summary>
  public UInt32? PtCount { get; set; }
  /// <summary>
  ///   formatCode
  /// </summary>
  public string? FormatCode { get; set; }
  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }
  public Collection<NumericValue>? NumericValues { get; set; }
}
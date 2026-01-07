namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public interface PageMargins
{
  /// <summary>
  ///   l
  /// </summary>
  public Double? L { get; set; }
  /// <summary>
  ///   r
  /// </summary>
  public Double? R { get; set; }
  /// <summary>
  ///   t
  /// </summary>
  public Double? T { get; set; }
  /// <summary>
  ///   b
  /// </summary>
  public Double? B { get; set; }
  /// <summary>
  ///   header
  /// </summary>
  public Double? Header { get; set; }
  /// <summary>
  ///   footer
  /// </summary>
  public Double? Footer { get; set; }
}
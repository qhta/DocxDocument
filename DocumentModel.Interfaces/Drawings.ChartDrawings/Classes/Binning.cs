namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Binning Class.
/// </summary>
public class Binning: ModelElement
{
  /// <summary>
  ///   intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public IntervalClosedSide? IntervalClosed { get; set; }
  /// <summary>
  ///   underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Underflow { get; set; }
  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Overflow { get; set; }
  /// <summary>
  ///   Xsddouble.
  /// </summary>
  public string? Xsddouble { get; set; }
  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  public string? BinCountXsdunsignedInt { get; set; }
}
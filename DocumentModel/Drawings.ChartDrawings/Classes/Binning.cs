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
  public String? Underflow { get; set; }

  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Overflow { get; set; }

  /// <summary>
  ///   Xsddouble.
  /// </summary>
  public String? Xsddouble { get; set; }

  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  public String? BinCountXsdunsignedInt { get; set; }
}
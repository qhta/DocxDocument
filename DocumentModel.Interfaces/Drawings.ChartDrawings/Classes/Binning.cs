namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the binning configuration for histogram charts that groups continuous data into discrete intervals.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the parameters for organizing continuous
///   numeric data into bins (intervals or buckets) for histogram visualization. Binning is essential for creating
///   histograms that display the distribution and frequency of data values across ranges. The configuration
///   includes settings for how interval boundaries are handled (whether intervals are closed on the left or right),
///   overflow and underflow thresholds for values outside the normal range, and the method for determining bin
///   divisions (either by specifying bin width or bin count). This enables flexible histogram creation that can
///   accommodate various data distributions and analysis requirements.
/// </remarks>
public interface Binning : IModelElement
{
  /// <summary>
  ///   Gets or sets which side of the interval boundary is included in the bin.
  /// </summary>
  /// <value>
  ///   An <see cref="IntervalClosedSide"/> value specifying whether intervals are closed on the left or right,
  ///   or <c>null</c> to use the default interval closure behavior.
  /// </value>
  /// <remarks>
   ///   Interval closure determines whether boundary values belong to the lower or upper bin. For example,
  ///   with left-closed intervals [0, 10), a value of 10 belongs to the next bin [10, 20). With right-closed
  ///   intervals (0, 10], a value of 10 belongs to the current bin. This affects how boundary values are
  ///   counted in the frequency distribution.
  /// </remarks>
  public IntervalClosedSide? IntervalClosed { get; set; }

  /// <summary>
  ///   Gets or sets the threshold value for the underflow bin.
  /// </summary>
  /// <value>
  ///   A string containing the numeric threshold for underflow values,
  ///   or <c>null</c> if no underflow bin is defined.
  /// </value>
  /// <remarks>
   ///   The underflow value defines the lower boundary below which all values are grouped into a single
  ///   underflow bin. This is useful for handling outliers or extreme low values that would otherwise
  ///   create excessive bins or skew the histogram distribution.
  /// </remarks>
  public string? Underflow { get; set; }

  /// <summary>
  ///   Gets or sets the threshold value for the overflow bin.
  /// </summary>
  /// <value>
  ///   A string containing the numeric threshold for overflow values,
  ///   or <c>null</c> if no overflow bin is defined.
  /// </value>
  /// <remarks>
   ///   The overflow value defines the upper boundary above which all values are grouped into a single
  ///   overflow bin. This is useful for handling outliers or extreme high values that would otherwise
  ///   create excessive bins or skew the histogram distribution.
  /// </remarks>
  public string? Overflow { get; set; }

  /// <summary>
  ///   Gets or sets the width of each bin interval.
  /// </summary>
  /// <value>
  ///   A string containing the numeric bin width value,
  ///   or <c>null</c> if bin width is not specified (using bin count instead).
  /// </value>
  /// <remarks>
  ///   The bin width determines the size of each interval in the histogram. For example, a bin width
  ///   of 10 creates bins like [0-10), [10-20), [20-30), etc. Either <see cref="Xsddouble"/> (bin width)
  ///   or <see cref="BinCountXsdunsignedInt"/> (bin count) should be specified, but typically not both.
  ///   Using bin width provides consistent interval sizes regardless of the data range.
  /// </remarks>
  public string? Xsddouble { get; set; }

  /// <summary>
  ///   Gets or sets the number of bins to create for the histogram.
  /// </summary>
  /// <value>
  ///   A string containing the unsigned integer bin count value,
  ///   or <c>null</c> if bin count is not specified (using bin width instead).
  /// </value>
  /// <remarks>
  ///   The bin count determines how many bins to create by dividing the data range into equal intervals.
  ///   For example, a bin count of 10 divides the range between minimum and maximum values into 10 equal bins.
  ///   Either <see cref="Xsddouble"/> (bin width) or <see cref="BinCountXsdunsignedInt"/> (bin count) should
  ///   be specified, but typically not both. Using bin count ensures a fixed number of bins regardless of
  ///   the data range, which can be useful for consistent histogram appearance.
  /// </remarks>
  public string? BinCountXsdunsignedInt { get; set; }
}
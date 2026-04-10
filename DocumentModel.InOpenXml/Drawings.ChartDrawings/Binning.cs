using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the binning configuration for histogram charts that groups continuous data into discrete intervals.
/// </summary>
/// <remarks>
///   This class defines the parameters for organizing continuous
///   numeric data into bins (intervals or buckets) for histogram visualization. Binning is essential for creating
///   histograms that display the distribution and frequency of data values across ranges. The configuration
///   includes settings for how interval boundaries are handled (whether intervals are closed on the left or right),
///   overflow and underflow thresholds for values outside the normal range, and the method for determining bin
///   divisions (either by specifying bin width or bin count). This enables flexible histogram creation that can
///   accommodate various data distributions and analysis requirements.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Binning))]
[XmlRoot("Binning", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Binning : ModelElement<DXO16DCD.Binning>
{
 /// <summary>
 /// Specifies the interval closed.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Binning.IntervalClosed))]
 public IntervalClosedSide? IntervalClosed { get => _IntervalClosed; set => UpdateField(ref _IntervalClosed, value, nameof(IntervalClosed)); }

 private IntervalClosedSide? _IntervalClosed;
 /// <summary>
 /// Specifies the underflow.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Binning.Underflow))]
 public string? Underflow { get => _Underflow; set => UpdateField(ref _Underflow, value, nameof(Underflow)); }

 private string? _Underflow;
 /// <summary>
 /// Specifies the overflow.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Binning.Overflow))]
 public string? Overflow { get => _Overflow; set => UpdateField(ref _Overflow, value, nameof(Overflow)); }

 private string? _Overflow;
 /// <summary>
 /// Specifies the xsddouble.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Binning.Xsddouble))]
 public string? Xsddouble { get => _Xsddouble; set => UpdateField(ref _Xsddouble, value, nameof(Xsddouble)); }

 private string? _Xsddouble;
 /// <summary>
 /// Specifies the bin count xsdunsigned int.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Binning.BinCountXsdunsignedInt))]
 public string? BinCountXsdunsignedInt { get => _BinCountXsdunsignedInt; set => UpdateField(ref _BinCountXsdunsignedInt, value, nameof(BinCountXsdunsignedInt)); }

 private string? _BinCountXsdunsignedInt;
}
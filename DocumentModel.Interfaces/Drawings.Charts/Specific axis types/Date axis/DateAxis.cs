namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a date axis for a chart, including text properties, labeling, time units, and extension list.
/// </summary>
public interface DateAxis: AxisType
{
  /// <summary>
  ///   Indicates whether labels are automatically generated.
  /// </summary>
  public bool? AutoLabeled { get; set; }

  /// <summary>
  ///   Offset for the axis labels.
  /// </summary>
  public UInt16? LabelOffset { get; set; }

  /// <summary>
  ///   Base time unit for the axis.
  /// </summary>
  public TimeUnitKind? BaseTimeUnit { get; set; }

  /// <summary>
  ///   Major unit value for the axis.
  /// </summary>
  public Double? MajorUnit { get; set; }

  /// <summary>
  ///   Major time unit for the axis.
  /// </summary>
  public TimeUnitKind? MajorTimeUnit { get; set; }

  /// <summary>
  ///   Minor unit value for the axis.
  /// </summary>
  public Double? MinorUnit { get; set; }

  /// <summary>
  ///   Minor time unit for the axis.
  /// </summary>
  public TimeUnitKind? MinorTimeUnit { get; set; }

  /// <summary>
  ///   Extension list for additional date axis properties.
  /// </summary>
  public DateAxExtensionList? DateAxExtensionList { get; set; }
}
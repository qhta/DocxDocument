namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a category axis for a chart, including axis ID, scaling, position, gridlines, title, formatting, tick marks, labels, crossing, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.CategoryAxis))]
public class CategoryAxis : AbstractAxis<DXDC.CategoryAxis>
{
  /// <summary>
  ///   Indicates whether labels are automatically generated.
  /// </summary>
  public bool? AutoLabeled { get; set; }

  /// <summary>
  ///   Alignment of the axis labels.
  /// </summary>
  public LabelAlignment? LabelAlignment { get; set; }

  /// <summary>
  ///   Offset for the axis labels.
  /// </summary>
  public UInt16? LabelOffset { get; set; }

  /// <summary>
  ///   Number of tick labels to skip.
  /// </summary>
  public Int32? TickLabelSkip { get; set; }

  /// <summary>
  ///   Number of tick marks to skip.
  /// </summary>
  public Int32? TickMarkSkip { get; set; }

  /// <summary>
  ///   Indicates whether multi-level labels are disabled.
  /// </summary>
  public bool? NoMultiLevelLabels { get; set; }

  /// <summary>
  ///   Extension list for additional axis properties.
  /// </summary>
  public CatAxExtensionList? CatAxExtensionList { get; set; }
}
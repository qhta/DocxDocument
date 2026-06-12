namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a category axis for a chart, including axis ID, scaling, position, gridlines, title, formatting, tick marks, labels, crossing, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.CategoryAxis))]
[XmlRoot("CategoryAxis", Namespace = "DocumentModel.Drawings.Charts")]
public partial class CategoryAxis : AbstractAxis<DXDC.CategoryAxis>
{
  /// <summary>
  ///   Indicates whether labels are automatically generated.
  /// </summary>
  public bool? AutoLabeled { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Alignment of the axis labels.
  /// </summary>
  public LabelAlignment? LabelAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Offset for the axis labels.
  /// </summary>
  public UInt16? LabelOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Number of tick labels to skip.
  /// </summary>
  public Int32? TickLabelSkip { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Number of tick marks to skip.
  /// </summary>
  public Int32? TickMarkSkip { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Indicates whether multi-level labels are disabled.
  /// </summary>
  public bool? NoMultiLevelLabels { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Extension list for additional axis properties.
  /// </summary>
  public CatAxExtensionList? CatAxExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a date axis for a chart, including text properties, labeling, time units, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.DateAxis))]
[XmlRoot("DateAxis", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DateAxis : AbstractAxis<DXDC.DateAxis>
{
 /// <summary>
 ///   Indicates whether labels are automatically generated.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AutoLabeled))]
 public bool? AutoLabeled { get => _AutoLabeled; set => UpdateField(ref _AutoLabeled, value, nameof(AutoLabeled)); }
 private bool? _AutoLabeled;

 /// <summary>
 ///   Offset for the axis labels.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.LabelOffset))]
 public UInt16? LabelOffset { get => _LabelOffset; set => UpdateField(ref _LabelOffset, value, nameof(LabelOffset)); }
 private UInt16? _LabelOffset;

 /// <summary>
 ///   Base time unit for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.BaseTimeUnit))]
 public TimeUnit? BaseTimeUnit { get => _BaseTimeUnit; set => UpdateField(ref _BaseTimeUnit, value, nameof(BaseTimeUnit)); }
 private TimeUnit? _BaseTimeUnit;

 /// <summary>
 ///   Major unit value for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MajorUnit))]
 public Double? MajorUnit { get => _MajorUnit; set => UpdateField(ref _MajorUnit, value, nameof(MajorUnit)); }
 private Double? _MajorUnit;

 /// <summary>
 ///   Major time unit for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MajorTimeUnit))]
 public TimeUnit? MajorTimeUnit { get => _MajorTimeUnit; set => UpdateField(ref _MajorTimeUnit, value, nameof(MajorTimeUnit)); }
 private TimeUnit? _MajorTimeUnit;

 /// <summary>
 ///   Minor unit value for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MinorUnit))]
 public Double? MinorUnit { get => _MinorUnit; set => UpdateField(ref _MinorUnit, value, nameof(MinorUnit)); }
 private Double? _MinorUnit;

 /// <summary>
 ///   Minor time unit for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MinorTimeUnit))]
 public TimeUnit? MinorTimeUnit { get => _MinorTimeUnit; set => UpdateField(ref _MinorTimeUnit, value, nameof(MinorTimeUnit)); }
 private TimeUnit? _MinorTimeUnit;

 /// <summary>
 ///   Extension list for additional date axis properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DateAxExtensionList))]
 public DateAxExtensionList? DateAxExtensionList { get => _DateAxExtensionList; set => UpdateField(ref _DateAxExtensionList, value, nameof(DateAxExtensionList)); }
 private DateAxExtensionList? _DateAxExtensionList;
}
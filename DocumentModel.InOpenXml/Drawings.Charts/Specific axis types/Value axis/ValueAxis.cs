namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a value axis for a chart, including crossing behavior, major and minor units, display units, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.ValueAxis))]
[XmlRoot("ValueAxis", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ValueAxis : AbstractAxis<DXDC.ValueAxis>
{
 /// <summary>
 ///   Specifies how the axis crosses between categories or data points.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.CrossBetween))]
 public CrossBetween? CrossBetween { get => _CrossBetween; set => UpdateField(ref _CrossBetween, value, nameof(CrossBetween)); }
 private CrossBetween? _CrossBetween;

 /// <summary>
 ///   Major unit value for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MajorUnit))]
 public Double? MajorUnit { get => _MajorUnit; set => UpdateField(ref _MajorUnit, value, nameof(MajorUnit)); }
 private Double? _MajorUnit;

 /// <summary>
 ///   Minor unit value for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.MinorUnit))]
 public Double? MinorUnit { get => _MinorUnit; set => UpdateField(ref _MinorUnit, value, nameof(MinorUnit)); }
 private Double? _MinorUnit;

 /// <summary>
 ///   Display units configuration for the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DisplayUnits))]
 public DisplayUnits? DisplayUnits { get => _DisplayUnits; set => UpdateField(ref _DisplayUnits, value, nameof(DisplayUnits)); }
 private DisplayUnits? _DisplayUnits;

 /// <summary>
 ///   Extension list for additional value axis properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ValAxExtensionList))]
 public ValAxExtensionList? ValAxExtensionList { get => _ValAxExtensionList; set => UpdateField(ref _ValAxExtensionList, value, nameof(ValAxExtensionList)); }
 private ValAxExtensionList? _ValAxExtensionList;
}
namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a data point in a chart series.
///   A data point defines the value, formatting, and visual properties for a single entry in a chart, such as a bar, line, or marker.
///   This class allows configuration of index, marker, shape, and additional options for each data point.
/// </summary>
[OpenXmlType(typeof(DXDC.DataPoint))]
[XmlRoot("DataPoint", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataPoint : ModelElement<DXDC.DataPoint>
{
 /// <summary>
 ///   Index of the data point within the series or collection.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

 private UInt32? _Index;
 /// <summary>
 ///   Indicates whether the data point should be inverted if its value is negative.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.InvertIfNegative))]
 public bool? InvertIfNegative { get => _InvertIfNegative; set => UpdateField(ref _InvertIfNegative, value, nameof(InvertIfNegative)); }

 private bool? _InvertIfNegative;
 /// <summary>
 ///   Marker configuration for the data point, used in line and scatter charts.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.Marker))]
 public Marker? Marker { get => _Marker; set => UpdateField(ref _Marker, value, nameof(Marker)); }

 private Marker? _Marker;
 /// <summary>
 ///   Indicates whether the data point is rendered as a 3D bubble (for bubble charts).
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.Bubble3D))]
 public bool? Bubble3D { get => _Bubble3D; set => UpdateField(ref _Bubble3D, value, nameof(Bubble3D)); }

 private bool? _Bubble3D;
 /// <summary>
 ///   Explosion value for the data point, used in pie and doughnut charts to separate the slice.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.Explosion))]
 public UInt32? Explosion { get => _Explosion; set => UpdateField(ref _Explosion, value, nameof(Explosion)); }

 private UInt32? _Explosion;
 /// <summary>
 ///   Visual and shape properties for the data point.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }

 private ChartShapeProperties? _ChartShapeProperties;
 /// <summary>
 ///   Picture options for the data point, such as fill or image settings.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.PictureOptions))]
 public PictureOptions? PictureOptions { get => _PictureOptions; set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions)); }

 private PictureOptions? _PictureOptions;
 /// <summary>
 ///   Collection of extension elements for additional data point customization.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataPoint.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}
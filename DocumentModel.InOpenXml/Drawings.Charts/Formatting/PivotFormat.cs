namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Defines the formatting properties for a pivot chart element.
/// </summary>
[OpenXmlType(typeof(DXDC.PivotFormat))]
[DataContract]
[XmlRoot("PivotFormat", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PivotFormat : ModelElement<DXDC.PivotFormat>
{
 /// <summary>
 /// Index of the pivot format in the collection.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PivotFormat.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }
 private UInt32? _Index;

 /// <summary>
 /// Shape properties applied to the pivot element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PivotFormat.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;

 /// <summary>
 /// Marker properties for the data point.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PivotFormat.Marker))]
 public Marker? Marker { get => _Marker; set => UpdateField(ref _Marker, value, nameof(Marker)); }
 private Marker? _Marker;

 /// <summary>
 /// Data label associated with the pivot format.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PivotFormat.DataLabel))]
 public DataLabel? DataLabel { get => _DataLabel; set => UpdateField(ref _DataLabel, value, nameof(DataLabel)); }
 private DataLabel? _DataLabel;

 /// <summary>
 /// Extensibility container for future feature extensions.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PivotFormat.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}
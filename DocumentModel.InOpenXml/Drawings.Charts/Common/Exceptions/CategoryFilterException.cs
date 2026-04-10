namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an exception to a category filter in a chart, including references, shape properties, explosion, inversion, 3D bubble option, marker, and data label.
/// </summary>
[OpenXmlType(typeof(DXO13DC.CategoryFilterException))]
[XmlRoot("CategoryFilterException", Namespace = "DocumentModel.Drawings.Charts")]
public partial class CategoryFilterException : ModelElement<DXO13DC.CategoryFilterException>
{
 /// <summary>
 ///   Sequence of references associated with the category filter exception.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.SequenceOfReferences))]
 public string? SequenceOfReferences { get => _SequenceOfReferences; set => UpdateField(ref _SequenceOfReferences, value, nameof(SequenceOfReferences)); }

 private string? _SequenceOfReferences;
 /// <summary>
 ///   Shape properties for the exception.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.ShapeProperties))]
 [OpenXmlType(typeof(DXO13DC.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 ///   Explosion value indicating how far a slice is pulled from the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.Explosion))]
 public UInt32? Explosion { get => _Explosion; set => UpdateField(ref _Explosion, value, nameof(Explosion)); }

 private UInt32? _Explosion;
 /// <summary>
 ///   Indicates whether to invert colors if the value is negative.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.InvertIfNegativeBoolean))]
 public bool? InvertIfNegativeBoolean { get => _InvertIfNegativeBoolean; set => UpdateField(ref _InvertIfNegativeBoolean, value, nameof(InvertIfNegativeBoolean)); }

 private bool? _InvertIfNegativeBoolean;
 /// <summary>
 ///   Indicates whether bubbles are rendered in 3D.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.Bubble3D))]
 public bool? Bubble3D { get => _Bubble3D; set => UpdateField(ref _Bubble3D, value, nameof(Bubble3D)); }

 private bool? _Bubble3D;
 /// <summary>
 ///   Marker configuration for the exception.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.Marker))]
 public Marker? Marker { get => _Marker; set => UpdateField(ref _Marker, value, nameof(Marker)); }

 private Marker? _Marker;
 /// <summary>
 ///   Data label configuration for the exception.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.CategoryFilterException.DataLabel))]
 public DataLabel? DataLabel { get => _DataLabel; set => UpdateField(ref _DataLabel, value, nameof(DataLabel)); }

 private DataLabel? _DataLabel;
}
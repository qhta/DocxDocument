namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the settings for inverting solid fill format for negative data points.
///   This class defines the shape properties used when the fill is inverted.
/// </summary>
[OpenXmlType(typeof(DXO10DC.InvertSolidFillFormat))]
[DataContract]
[XmlRoot("InvertSolidFillFormat", Namespace = "DocumentModel.Drawings.Charts")]
public partial class InvertSolidFillFormat : ModelElement<DXO10DC.InvertSolidFillFormat>
{
 /// <summary>
 ///   Shape properties applied when the solid fill is inverted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DC.InvertSolidFillFormat.ShapeProperties))]
 [OpenXmlType(typeof(DXO10DC.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;
}
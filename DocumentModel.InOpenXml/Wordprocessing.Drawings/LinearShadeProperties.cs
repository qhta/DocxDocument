namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the properties for a linear gradient shade applied to a drawing element in a Wordprocessing document.
/// This class provides configuration for the angle and scaling of the linear gradient, enabling precise control over gradient direction and behavior.
/// </summary>
[OpenXmlType(typeof(DXO10W.LinearShadeProperties))]
[DataContract]
[XmlRoot("LinearShadeProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class LinearShadeProperties : ModelElement<DXO10W.LinearShadeProperties>
{
 /// <summary>
 /// The angle of the linear gradient, specified in degrees, determining the direction of the gradient fill.
 /// </summary>
 public Int32? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }
 private Int32? _Angle;

 /// <summary>
 /// Indicates whether the gradient is scaled to fit the shape, affecting how the gradient is rendered within the element.
 /// </summary>
 public Boolean? Scaled { get => _Scaled; set => UpdateField(ref _Scaled, value, nameof(Scaled)); }
 private Boolean? _Scaled;
}
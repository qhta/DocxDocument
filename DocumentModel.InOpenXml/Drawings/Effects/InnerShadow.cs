namespace DocumentModel.Drawings;
/// <summary>
///   Represents an inner shadow effect, including blur, offset, direction, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.InnerShadow))]
[XmlRoot("InnerShadow", Namespace = "DocumentModel.Drawings")]
public partial class InnerShadow : ModelElement<DXD.InnerShadow>
{
 /// <summary>
 ///   Blur radius of the inner shadow.
 /// </summary>
 public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }
 private Int64? _BlurRadius;

 /// <summary>
 ///   Distance to offset the inner shadow from the object.
 /// </summary>
 public Int64? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }
 private Int64? _Distance;

 /// <summary>
 ///   Direction angle of the inner shadow.
 /// </summary>
 public Int32? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }
 private Int32? _Direction;

 /// <summary>
 ///   Inner shadow color specified using the RGB color model with percentage values.
 /// </summary>
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;

}
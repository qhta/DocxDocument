namespace DocumentModel.Drawings;
/// <summary>
///   Represents a transform effect, allowing adjustment of scaling, skew, and shift for a drawing element.
/// </summary>
[OpenXmlType(typeof(DXD.TransformEffect))]
[XmlRoot("TransformEffect", Namespace = "DocumentModel.Drawings")]
public partial class TransformEffect : ModelElement<DXD.TransformEffect>
{
 /// <summary>
 ///   Horizontal scaling ratio.
 /// </summary>
 public Int32? HorizontalRatio { get => _HorizontalRatio; set => UpdateField(ref _HorizontalRatio, value, nameof(HorizontalRatio)); }

 private Int32? _HorizontalRatio;
 /// <summary>
 ///   Vertical scaling ratio.
 /// </summary>
 public Int32? VerticalRatio { get => _VerticalRatio; set => UpdateField(ref _VerticalRatio, value, nameof(VerticalRatio)); }

 private Int32? _VerticalRatio;
 /// <summary>
 ///   Horizontal skew value.
 /// </summary>
 public Int32? HorizontalSkew { get => _HorizontalSkew; set => UpdateField(ref _HorizontalSkew, value, nameof(HorizontalSkew)); }

 private Int32? _HorizontalSkew;
 /// <summary>
 ///   Vertical skew value.
 /// </summary>
 public Int32? VerticalSkew { get => _VerticalSkew; set => UpdateField(ref _VerticalSkew, value, nameof(VerticalSkew)); }

 private Int32? _VerticalSkew;
 /// <summary>
 ///   Horizontal shift value.
 /// </summary>
 public Int64? HorizontalShift { get => _HorizontalShift; set => UpdateField(ref _HorizontalShift, value, nameof(HorizontalShift)); }

 private Int64? _HorizontalShift;
 /// <summary>
 ///   Vertical shift value.
 /// </summary>
 public Int64? VerticalShift { get => _VerticalShift; set => UpdateField(ref _VerticalShift, value, nameof(VerticalShift)); }

 private Int64? _VerticalShift;
}
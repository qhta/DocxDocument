namespace DocumentModel.Drawings;
/// <summary>
///   Represents a positive 2D size, defined by its length and width.
/// </summary>
[OpenXmlType(typeof(DXD.PositiveSize2DType))]
[XmlRoot("PositiveSize2DType", Namespace = "DocumentModel.Drawings")]
public partial class PositiveSize2DType : ModelElement<DXD.PositiveSize2DType>
{
 /// <summary>
 ///   Length of the extent.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PositiveSize2DType.Cx))]
 public Int64? Cx { get => _Cx; set => UpdateField(ref _Cx, value, nameof(Cx)); }

 private Int64? _Cx;
 /// <summary>
 ///   Width of the extent.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PositiveSize2DType.Cy))]
 public Int64? Cy { get => _Cy; set => UpdateField(ref _Cy, value, nameof(Cy)); }

 private Int64? _Cy;
}
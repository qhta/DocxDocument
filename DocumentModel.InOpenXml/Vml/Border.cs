namespace DocumentModel.Vml;
/// <summary>
/// Represents a border type definition in a WordprocessingML document.
/// This class provides properties for border style, width, and shadow effect, enabling advanced formatting and visual separation of document content.
/// </summary>
[OpenXmlType(typeof(DXVW.BorderType))]
[DataContract]
[XmlRoot("Border", Namespace = "DocumentModel.Vml")]
public partial class Border : ModelElement<DXVW.BorderType>
{
 /// <summary>
 /// Border style, specifying the type of border (e.g., single, double, dashed).
 /// </summary>
 public BorderType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private BorderType? _Type;

 /// <summary>
 /// Border width, specified as a 64-bit integer value.
 /// </summary>
 public Int64? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private Int64? _Width;

 /// <summary>
 /// Indicates whether the border has a shadow effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.BorderType.Shadow))]
 public bool? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }
 private bool? _Shadow;
}
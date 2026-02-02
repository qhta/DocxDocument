namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for the line end, including type, width, and length of the line head or end.
/// </summary>
[OpenXmlType(typeof(DXD.LineEndPropertiesType))]
public partial class LineEndPropertiesType : ModelElement<DXD.LineEndPropertiesType>
{
 /// <summary>
 ///   Type of the line head or end.
 /// </summary>
 public LineEndType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private LineEndType? _Type;
 /// <summary>
 ///   Width of the line head or end.
 /// </summary>
 public LineEndWidth? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private LineEndWidth? _Width;
 /// <summary>
 ///   Length of the line head or end.
 /// </summary>
 public LineEndLength? Length { get => _Length; set => UpdateField(ref _Length, value, nameof(Length)); }

 private LineEndLength? _Length;
}
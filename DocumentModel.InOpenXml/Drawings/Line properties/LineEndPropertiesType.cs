namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for the line end, including type, width, and length of the line head or end.
/// </summary>
public partial class LineEndPropertiesType : ModelElement<DXD.LineEndPropertiesType>
{
    /// <summary>
    ///   Type of the line head or end.
    /// </summary>
    public LineEndKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private LineEndKind? _Type;
    /// <summary>
    ///   Width of the line head or end.
    /// </summary>
    public LineEndWidthKind? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private LineEndWidthKind? _Width;
    /// <summary>
    ///   Length of the line head or end.
    /// </summary>
    public LineEndLengthKind? Length { get => _Length; set => UpdateField(ref _Length, value, nameof(Length)); }

    private LineEndLengthKind? _Length;
}
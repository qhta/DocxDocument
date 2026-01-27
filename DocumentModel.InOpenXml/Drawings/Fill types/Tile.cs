namespace DocumentModel.Drawings;
/// <summary>
///   Represents tiling options for a fill, including offset, scaling, flipping, and alignment.
/// </summary>
public partial class Tile : ModelElement<DXD.Tile>
{
    /// <summary>
    ///   Horizontal offset for the tile.
    /// </summary>
    public Int64? HorizontalOffset { get => _HorizontalOffset; set => UpdateField(ref _HorizontalOffset, value, nameof(HorizontalOffset)); }

    private Int64? _HorizontalOffset;
    /// <summary>
    ///   Vertical offset for the tile.
    /// </summary>
    public Int64? VerticalOffset { get => _VerticalOffset; set => UpdateField(ref _VerticalOffset, value, nameof(VerticalOffset)); }

    private Int64? _VerticalOffset;
    /// <summary>
    ///   Horizontal scaling ratio for the tile.
    /// </summary>
    public Int32? HorizontalRatio { get => _HorizontalRatio; set => UpdateField(ref _HorizontalRatio, value, nameof(HorizontalRatio)); }

    private Int32? _HorizontalRatio;
    /// <summary>
    ///   Vertical scaling ratio for the tile.
    /// </summary>
    public Int32? VerticalRatio { get => _VerticalRatio; set => UpdateField(ref _VerticalRatio, value, nameof(VerticalRatio)); }

    private Int32? _VerticalRatio;
    /// <summary>
    ///   Tile flipping mode.
    /// </summary>
    public TileFlipKind? Flip { get => _Flip; set => UpdateField(ref _Flip, value, nameof(Flip)); }

    private TileFlipKind? _Flip;
    /// <summary>
    ///   Alignment of the tile within the filled area.
    /// </summary>
    public RectangleAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

    private RectangleAlignmentKind? _Alignment;
}
namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Picture Fill.
/// </summary>
public partial class BlipFill : ModelElement<DXDP.BlipFill>
{
    /// <summary>
    ///   DPI Setting
    /// </summary>
    public UInt32? Dpi { get => _Dpi; set => UpdateField(ref _Dpi, value, nameof(Dpi)); }

    private UInt32? _Dpi;
    /// <summary>
    ///   Rotate With Shape
    /// </summary>
    public bool? RotateWithShape { get => _RotateWithShape; set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape)); }

    private bool? _RotateWithShape;
    /// <summary>
    ///   Blip.
    /// </summary>
    public Blip? Blip { get => _Blip; set => UpdateField(ref _Blip, value, nameof(Blip)); }

    private Blip? _Blip;
    /// <summary>
    ///   Source Rectangle.
    /// </summary>
    public RelativeRectangleType? SourceRectangle { get => _SourceRectangle; set => UpdateField(ref _SourceRectangle, value, nameof(SourceRectangle)); }

    private RelativeRectangleType? _SourceRectangle;
    public Tile? Tile { get => _Tile; set => UpdateField(ref _Tile, value, nameof(Tile)); }

    private Tile? _Tile;
    public Stretch? Stretch { get => _Stretch; set => UpdateField(ref _Stretch, value, nameof(Stretch)); }

    private Stretch? _Stretch;
}
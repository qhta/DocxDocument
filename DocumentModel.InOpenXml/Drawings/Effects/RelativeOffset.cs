namespace DocumentModel.Drawings;
/// <summary>
///   Represents a relative offset effect, specifying X and Y offset values for positioning.
/// </summary>
public partial class RelativeOffset : ModelElement
{
    /// <summary>
    ///   X offset value.
    /// </summary>
    public Int32? OffsetX { get => _OffsetX; set => UpdateField(ref _OffsetX, value, nameof(OffsetX)); }

    private Int32? _OffsetX;
    /// <summary>
    ///   Y offset value.
    /// </summary>
    public Int32? OffsetY { get; set; }
}
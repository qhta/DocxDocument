namespace DocumentModel.Drawings;
/// <summary>
///   Represents the extent (width and height) for 2D drawings, measured in English Metric Units (EMUs).
/// </summary>
public partial class Extent : ModelElement<DXDW.Extent>
{
    /// <summary>
    ///   Width of the extent in EMUs.
    /// </summary>
    public EMU? Cx { get => _Cx; set => UpdateField(ref _Cx, value, nameof(Cx)); }

    private EMU? _Cx;
    /// <summary>
    ///   Height of the extent in EMUs.
    /// </summary>
    public EMU? Cy { get => _Cy; set => UpdateField(ref _Cy, value, nameof(Cy)); }

    private EMU? _Cy;
}
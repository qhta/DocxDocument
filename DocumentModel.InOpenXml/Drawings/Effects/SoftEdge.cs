namespace DocumentModel.Drawings;
/// <summary>
///   Represents a soft edge effect, allowing adjustment of the edge radius for a drawing element.
/// </summary>
public partial class SoftEdge : ModelElement<DXD.SoftEdge>
{
    /// <summary>
    ///   Radius of the soft edge effect.
    /// </summary>
    public Int64? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }

    private Int64? _Radius;
}
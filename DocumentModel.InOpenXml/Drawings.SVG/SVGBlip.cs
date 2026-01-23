namespace DocumentModel.Drawings.SVG;
/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public partial class SVGBlip : ModelElement<DXO19DS.SVGBlip>
{
    /// <summary>
    ///   Embedded Picture Reference
    /// </summary>
    public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }

    private string? _Embed;
    /// <summary>
    ///   Linked Picture Reference
    /// </summary>
    public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

    private string? _Link;
}
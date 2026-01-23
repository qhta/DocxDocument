namespace DocumentModel.Drawings;
/// <summary>
///   Represents a shape guide, defining a named formula used for shape geometry calculations.
/// </summary>
public partial class ShapeGuide : ModelElement<DXD.ShapeGuide>
{
    /// <summary>
    ///   Name of the shape guide.
    /// </summary>
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   Formula used by the shape guide for geometry calculations.
    /// </summary>
    public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

    private string? _Formula;
}
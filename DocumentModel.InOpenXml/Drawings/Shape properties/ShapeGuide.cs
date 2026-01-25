namespace DocumentModel.Drawings;
/// <summary>
///   Represents a shape guide, defining a named formula used for shape geometry calculations.
/// </summary>
public partial class ShapeGuide : ModelElement<DXD.ShapeGuide>
{
    /// <summary>
    ///   FontName of the shape guide.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeGuide.Name))]
    /// <summary>
    ///   FontName of the shape guide.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeGuide))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   Formula used by the shape guide for geometry calculations.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeGuide.Formula))]
    /// <summary>
    ///   Formula used by the shape guide for geometry calculations.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeGuide))]
    public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

    private string? _Formula;
}
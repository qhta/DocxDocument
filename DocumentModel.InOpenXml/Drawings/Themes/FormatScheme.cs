namespace DocumentModel.Drawings;
/// <summary>
///   Represents a format scheme, including name and style lists for fills, lines, effects, and background fills.
/// </summary>
public partial class FormatScheme : ModelElement<DXD.FormatScheme>
{
    /// <summary>
    ///   Name of the format scheme.
    /// </summary>
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
    private string? _Name;

    /// <summary>
    ///   List of fill styles used in the format scheme.
    /// </summary>
    public FillStyleList? FillStyleList { get; set; }
    /// <summary>
    ///   List of line styles used in the format scheme.
    /// </summary>
    public LineStyleList? LineStyleList { get; set; }
    /// <summary>
    ///   List of effect styles used in the format scheme.
    /// </summary>
    public EffectStyleList? EffectStyleList { get; set; }
    /// <summary>
    ///   List of background fill styles used in the format scheme.
    /// </summary>
    public FillStyleList? BackgroundFillStyleList { get; set; }
}
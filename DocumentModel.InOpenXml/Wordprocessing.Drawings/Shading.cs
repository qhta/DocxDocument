using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents shading formatting for a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the shading pattern, foreground color, and background color, enabling advanced visual effects for graphical objects.
/// </summary>
public partial class Shading : ModelElement
{
    /// <summary>
    /// The shading pattern applied to the drawing element, determining the style of the fill pattern.
    /// </summary>
    public ShadingPatternKind? Pattern { get => _Pattern; set => UpdateField(ref _Pattern, value, nameof(Pattern)); }

    private ShadingPatternKind? _Pattern;
    /// <summary>
    /// The color of the pattern foreground, specifying the primary color used in the shading pattern.
    /// </summary>
    public DocumentModel.Color? ForegroundColor { get; set; }
    /// <summary>
    /// The color of the pattern background, specifying the secondary color used in the shading pattern.
    /// </summary>
    public DocumentModel.Color? BackgroundColor { get; set; }
}
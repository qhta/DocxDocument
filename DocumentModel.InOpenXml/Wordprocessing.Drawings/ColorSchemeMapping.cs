namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents theme color mappings for a Wordprocessing document.
/// This interface provides properties for mapping theme color roles (such as background, text, accent, and hyperlink colors) to specific color scheme indexes, enabling flexible and consistent color theming throughout the document.
/// </summary>
public class ColorSchemeMapping: ModelElement<DXW.ColorSchemeMapping>
{
    
    /// <summary>
    /// Background 1 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Background1 { get; set; }
    
    /// <summary>
    /// Text 1 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Text1 { get; set; }
    
    /// <summary>
    /// Background 2 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Background2 { get; set; }
    
    /// <summary>
    /// Text 2 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Text2 { get; set; }
    
    /// <summary>
    /// Accent 1 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent1 { get; set; }
    
    /// <summary>
    /// Accent 2 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent2 { get; set; }
    
    /// <summary>
    /// Accent 3 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent3 { get; set; }
    
    /// <summary>
    /// Accent 4 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent4 { get; set; }
    
    /// <summary>
    /// Accent 5 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent5 { get; set; }
    
    /// <summary>
    /// Accent 6 theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Accent6 { get; set; }
    
    /// <summary>
    /// Hyperlink theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? Hyperlink { get; set; }
    
    /// <summary>
    /// Followed hyperlink theme color mapping.
    /// </summary>
    public ColorSchemeIndexKind? FollowedHyperlink { get; set; }
}
using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents shading formatting for a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the shading pattern, foreground color, and background color, enabling advanced visual effects for graphical objects.
/// </summary>
[OpenXmlType(typeof(DXW.Shading))]
public partial class Shading : ModelElement<DXW.Shading>
{
 /// <summary>
 /// The shading pattern applied to the drawing element, determining the style of the fill pattern.
 /// </summary>
 public ShadingPattern? Pattern { get => _Pattern; set => UpdateField(ref _Pattern, value, nameof(Pattern)); }

 private ShadingPattern? _Pattern;
 /// <summary>
 /// The color of the pattern foreground, specifying the primary color used in the shading pattern.
 /// </summary>
 public DocumentModel.AbstractColor? ForegroundColor { get => _ForegroundColor; set => UpdateField(ref _ForegroundColor, value, nameof(ForegroundColor)); }

 private DocumentModel.AbstractColor? _ForegroundColor;
 /// <summary>
 /// The color of the pattern background, specifying the secondary color used in the shading pattern.
 /// </summary>
 public DocumentModel.AbstractColor? BackgroundColor { get => _BackgroundColor; set => UpdateField(ref _BackgroundColor, value, nameof(BackgroundColor)); }

 private DocumentModel.AbstractColor? _BackgroundColor;
}
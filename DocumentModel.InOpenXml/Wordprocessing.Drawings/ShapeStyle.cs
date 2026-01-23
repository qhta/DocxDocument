using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the style settings for a shape in a Wordprocessing document.
/// This class provides references to line, fill, effect, and font styles, enabling consistent visual formatting for shapes.
/// </summary>
public partial class ShapeStyle : ModelElement
{
    /// <summary>
    /// Reference to the line style applied to the shape, specifying line color, width, and pattern.
    /// </summary>
    public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

    private LineReference? _LineReference;
    /// <summary>
    /// Reference to the fill style applied to the shape, specifying fill color, gradient, or pattern.
    /// </summary>
    public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }

    private FillReference? _FillReference;
    /// <summary>
    /// Reference to the effect style applied to the shape, such as shadow, glow, or reflection effects.
    /// </summary>
    public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }

    private EffectReference? _EffectReference;
    /// <summary>
    /// Reference to the font style used for text within the shape, specifying font family, size, and formatting.
    /// </summary>
    public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }

    private FontReference? _FontReference;
}
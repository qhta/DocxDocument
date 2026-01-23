namespace DocumentModel.Drawings;
/// <summary>
///   Represents a pattern fill, including preset pattern type and foreground/background colors.
/// </summary>
public partial class PatternFill : ModelElement<DXD.PatternFill>
{
    /// <summary>
    ///   Preset pattern type used for the fill.
    /// </summary>
    public PresetPatternKind? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

    private PresetPatternKind? _Preset;
    /// <summary>
    ///   Foreground color of the pattern.
    /// </summary>
    public ForegroundColor? ForegroundColor { get => _ForegroundColor; set => UpdateField(ref _ForegroundColor, value, nameof(ForegroundColor)); }

    private ForegroundColor? _ForegroundColor;
    /// <summary>
    ///   Background color of the pattern.
    /// </summary>
    public BackgroundColor? BackgroundColor { get => _BackgroundColor; set => UpdateField(ref _BackgroundColor, value, nameof(BackgroundColor)); }

    private BackgroundColor? _BackgroundColor;
}
namespace DocumentModel.Drawings;
/// <summary>
/// Represents background properties, including black and white rendering modes and target screen size for display.
/// </summary>
public partial class BackgroundProperties : ModelElement<DXO13D.BackgroundProperties>
{
    /// <summary>
    /// Gets or sets the black and white mode for background rendering.
    /// </summary>
    public BlackWhiteMode? Mode { get => _Mode; set => UpdateField(ref _Mode, value, nameof(Mode)); }

    private BlackWhiteMode? _Mode;
    /// <summary>
    /// Gets or sets the pure black and white mode for background rendering.
    /// </summary>
    public BlackWhiteMode? Pure { get; set; }
    /// <summary>
    /// Gets or sets the normal black and white mode for background rendering.
    /// </summary>
    public BlackWhiteMode? Normal { get; set; }
    /// <summary>
    /// Gets or sets the target screen size for which the background is optimized.
    /// </summary>
    public TargetScreenSize? TargetScreenSize { get; set; }
}
namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blend effect, allowing the combination of effects using a specified blend mode.
/// </summary>
public partial class Blend : ModelElement<DXD.Blend>
{
    /// <summary>
    /// Blend mode used to combine effects.
    /// </summary>
    public BlendMode? BlendMode { get => _BlendMode; set => UpdateField(ref _BlendMode, value, nameof(BlendMode)); }

    private BlendMode? _BlendMode;
    /// <summary>
    /// Effect container that is blended using the specified blend mode.
    /// </summary>
    public EffectContainer? EffectContainer { get; set; }
}
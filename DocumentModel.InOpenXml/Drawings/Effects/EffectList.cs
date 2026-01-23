namespace DocumentModel.Drawings;
/// <summary>
/// Represents a container for various drawing effects that can be applied to graphical elements.
/// </summary>
public partial class EffectList : ModelElement<DXD.EffectList>
{
    /// <summary>
    /// Blur effect applied to the element.
    /// </summary>
    public Blur? Blur { get => _Blur; set => UpdateField(ref _Blur, value, nameof(Blur)); }

    private Blur? _Blur;
    /// <summary>
    /// Fill overlay effect, which overlays a fill on the element.
    /// </summary>
    public FillOverlay? FillOverlay { get => _FillOverlay; set => UpdateField(ref _FillOverlay, value, nameof(FillOverlay)); }

    private FillOverlay? _FillOverlay;
    /// <summary>
    /// Glow effect, which adds a glowing outline to the element.
    /// </summary>
    public Glow? Glow { get => _Glow; set => UpdateField(ref _Glow, value, nameof(Glow)); }

    private Glow? _Glow;
    /// <summary>
    /// Inner shadow effect, which adds a shadow inside the boundaries of the element.
    /// </summary>
    public InnerShadow? InnerShadow { get => _InnerShadow; set => UpdateField(ref _InnerShadow, value, nameof(InnerShadow)); }

    private InnerShadow? _InnerShadow;
    /// <summary>
    /// Outer shadow effect, which adds a shadow outside the boundaries of the element.
    /// </summary>
    public OuterShadow? OuterShadow { get => _OuterShadow; set => UpdateField(ref _OuterShadow, value, nameof(OuterShadow)); }

    private OuterShadow? _OuterShadow;
    /// <summary>
    /// Preset shadow effect, which applies a predefined shadow style to the element.
    /// </summary>
    public PresetShadow? PresetShadow { get => _PresetShadow; set => UpdateField(ref _PresetShadow, value, nameof(PresetShadow)); }

    private PresetShadow? _PresetShadow;
    /// <summary>
    /// Reflection effect, which creates a mirrored reflection of the element.
    /// </summary>
    public Reflection? Reflection { get => _Reflection; set => UpdateField(ref _Reflection, value, nameof(Reflection)); }

    private Reflection? _Reflection;
    /// <summary>
    /// Soft edge effect, which softens the edges of the element.
    /// </summary>
    public SoftEdge? SoftEdge { get => _SoftEdge; set => UpdateField(ref _SoftEdge, value, nameof(SoftEdge)); }

    private SoftEdge? _SoftEdge;
}
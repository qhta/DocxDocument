namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha modulation effect, which modulates the alpha channel of an image or shape using an effect container.
/// </summary>
public partial class AlphaModulationEffect : ModelElement<DXD.AlphaModulationEffect>
{
    /// <summary>
    /// Effect container that defines the parameters for alpha modulation.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AlphaModulationEffect.EffectContainer))]
    /// <summary>
    /// Effect container that defines the parameters for alpha modulation.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AlphaModulationEffect))]
    public EffectContainer? EffectContainer { get => _EffectContainer; set => UpdateField(ref _EffectContainer, value, nameof(EffectContainer)); }

    private EffectContainer? _EffectContainer;
}
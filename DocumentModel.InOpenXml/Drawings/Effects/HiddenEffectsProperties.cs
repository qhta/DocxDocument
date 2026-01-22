namespace DocumentModel.Drawings;
/// <summary>
///   Represents hidden effects properties for a drawing element, including effect containers.
/// </summary>
public partial class HiddenEffectsProperties : ModelElement<DXO10D.HiddenEffectsProperties>
{
    /// <summary>
    ///   List of effects applied to the element.
    /// </summary>
    public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

    private EffectList? _EffectList;
    /// <summary>
    ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
    /// </summary>
    public EffectDag? EffectDag { get; set; }
}
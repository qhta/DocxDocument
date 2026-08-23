namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blend effect, allowing the combination of effects using a specified blend mode.
/// </summary>
[OpenXmlType(typeof(DXD.Blend))]
[DataContract]
[XmlRoot("Blend", Namespace = "DocumentModel.Drawings")]
public partial class Blend : ModelElement<DXD.Blend>
{
 /// <summary>
 /// Blend mode used to combine effects.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blend.BlendMode))]
 public BlendMode? BlendMode { get => _BlendMode ??= GetProperty<BlendMode?>(GetUpdatableElement()?.BlendMode); set => UpdateField(ref _BlendMode, value, nameof(BlendMode)); }
 private BlendMode? _BlendMode;

 /// <summary>
 /// Effect container that is blended using the specified blend mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blend.EffectContainer))]
 public EffectContainer? EffectContainer { get => _EffectContainer ??= GetProperty<EffectContainer?>(GetUpdatableElement()?.EffectContainer); set => UpdateField(ref _EffectContainer, value, nameof(EffectContainer)); }
 private EffectContainer? _EffectContainer;
}
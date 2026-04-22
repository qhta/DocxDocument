using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents background formatting settings for a drawing element in a Wordprocessing document.
/// This class provides properties for configuring fill, visual effects, and effect graphs applied to the background, enabling advanced visual customization.
/// </summary>
[OpenXmlType(typeof(DXO10WDC.BackgroundFormatting))]
[XmlRoot("BackgroundFormatting", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class BackgroundFormatting : ModelElement<DXO10WDC.BackgroundFormatting>
{
 /// <summary>
 /// Fill settings for the background, specifying color, gradient, or pattern fills.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;

 /// <summary>
 /// List of visual effects applied to the background, such as shadows, glows, and reflections.
 /// </summary>
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
 private EffectList? _EffectList;

 /// <summary>
 /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the background.
 /// </summary>
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
 private EffectDag? _EffectDag;
}
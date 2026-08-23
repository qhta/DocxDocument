using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents formatting settings that apply to an entire drawing element in a Wordprocessing document.
/// This class provides properties for configuring outline, visual effects, and effect graphs, enabling consistent and advanced appearance for the whole drawing object.
/// </summary>
[OpenXmlType(typeof(DXO10WDC.WholeFormatting))]
[DataContract]
[XmlRoot("WholeFormatting", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class WholeFormatting : ModelElement<DXO10WDC.WholeFormatting>
{
  /// <summary>
  /// Outline properties for the drawing element, including line style, color, and width.
  /// </summary>
  public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }
  private LineProperties? _Outline;

  /// <summary>
  /// List of visual effects applied to the drawing element, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
  private EffectList? _EffectList;

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the drawing element.
  /// </summary>
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
  private EffectDag? _EffectDag;
}
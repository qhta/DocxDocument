using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents formatting settings that apply to an entire drawing element in a Wordprocessing document.
/// This interface provides properties for configuring outline, visual effects, and effect graphs, enabling consistent and advanced appearance for the whole drawing object.
/// </summary>
public interface WholeFormatting
{

  /// <summary>
  /// Outline properties for the drawing element, including line style, color, and width.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  /// List of visual effects applied to the drawing element, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the drawing element.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}
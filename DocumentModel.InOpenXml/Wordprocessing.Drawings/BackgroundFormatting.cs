using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents background formatting settings for a drawing element in a Wordprocessing document.
/// This interface provides properties for configuring fill, visual effects, and effect graphs applied to the background, enabling advanced visual customization.
/// </summary>
public class BackgroundFormatting: ModelElement
{
  /// <summary>
  /// Fill settings for the background, specifying color, gradient, or pattern fills.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// List of visual effects applied to the background, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the background.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}
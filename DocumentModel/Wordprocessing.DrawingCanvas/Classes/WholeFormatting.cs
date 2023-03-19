using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the WholeFormatting Class.
/// </summary>
public class WholeFormatting: ModelElement
{
  /// <summary>
  ///   Outline.
  /// </summary>
  public Outline? Outline { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }
}
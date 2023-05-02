using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingCanvas;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
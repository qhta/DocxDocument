namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Effect Container.
/// </summary>
public class EffectList: ModelElement
{
  /// <summary>
  ///   Blur Effect.
  /// </summary>
  public Blur? Blur { get; set; }

  /// <summary>
  ///   FillOverlay.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }

  /// <summary>
  ///   Glow.
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  ///   InnerShadow.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }

  /// <summary>
  ///   OuterShadow.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }

  /// <summary>
  ///   PresetShadow.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }

  /// <summary>
  ///   Reflection.
  /// </summary>
  public Reflection? Reflection { get; set; }

  /// <summary>
  ///   SoftEdge.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }
}
using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingCanvas;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackgroundFormatting Class.
/// </summary>
public class BackgroundFormatting: ModelElement
{
  public bool? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public bool? GroupFill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }
}
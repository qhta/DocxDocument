using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the BackgroundFormatting Class.
/// </summary>
public class BackgroundFormatting: ModelElement
{
  public Boolean? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public Boolean? GroupFill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }
}
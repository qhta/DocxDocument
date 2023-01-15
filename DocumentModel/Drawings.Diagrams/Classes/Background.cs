namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
public class Background
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
namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Fill Style List.
/// </summary>
public class FillStyleList: ModelElement
{
  public bool? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public bool? GroupFill { get; set; }
}
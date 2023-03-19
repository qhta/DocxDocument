namespace DocumentModel.Drawings;

/// <summary>
///   Background Fill Style List.
/// </summary>
public class BackgroundFillStyleList: ModelElement
{
  [DefaultValue(false)]
  public Boolean NoFill { get; set; }

  [DefaultValue(false)]
  public Boolean GroupFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }
}
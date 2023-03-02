namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinValueColorEndPosition Class.
/// </summary>
public record MinValueColorEndPosition
{
  public Boolean? ExtremeValueColorPosition { get; set; }

  public Double? NumberColorPosition { get; set; }

  public Double? PercentageColorPosition { get; set; }
}
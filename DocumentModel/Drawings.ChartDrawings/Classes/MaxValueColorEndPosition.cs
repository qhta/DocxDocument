namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
public record MaxValueColorEndPosition
{
  public Boolean? ExtremeValueColorPosition { get; set; }

  public Double? NumberColorPosition { get; set; }

  public Double? PercentageColorPosition { get; set; }
}
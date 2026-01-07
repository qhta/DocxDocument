namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
public interface MaxValueColorEndPosition
{
  public bool? ExtremeValueColorPosition { get; set; }
  public Double? NumberColorPosition { get; set; }
  public Double? PercentageColorPosition { get; set; }
}
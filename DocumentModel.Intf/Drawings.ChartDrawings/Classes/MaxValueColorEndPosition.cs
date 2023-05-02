namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
public class MaxValueColorEndPosition: ModelElement
{
  public bool? ExtremeValueColorPosition { get; set; }

  public Double? NumberColorPosition { get; set; }

  public Double? PercentageColorPosition { get; set; }
}
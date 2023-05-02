namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MinValueColorEndPosition Class.
/// </summary>
public class MinValueColorEndPosition: ModelElement
{
  public bool? ExtremeValueColorPosition { get; set; }

  public Double? NumberColorPosition { get; set; }

  public Double? PercentageColorPosition { get; set; }
}
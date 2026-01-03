namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinValueColorEndPosition Class.
/// </summary>
public interface MinValueColorEndPosition: IModelElement
{
  public bool? ExtremeValueColorPosition { get; set; }
  public Double? NumberColorPosition { get; set; }
  public Double? PercentageColorPosition { get; set; }
}